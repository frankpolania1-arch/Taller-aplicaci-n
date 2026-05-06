using FPETDesktopApp.Controles.PermisosAplicacion;
using FPETDesktopApp.Recursos.Controles;
using FPETDesktopApp.Recursos.Controles.Base_de_datos.Consultas;
using FPETDesktopApp.Recursos.Servicios.GuardarMemoria;
using FPETDesktopApp.Recursos.Vistas.Jugador;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_final.Cartas;
using Trabajo_final.Scripts.API;


namespace FPETDesktopApp.Recursos.Vistas.Administrador
{
    public partial class VistaAdministrador : Form
    {
        CargarAPI cargarAPI;
        private List<DatosAPI> cartas = new List<DatosAPI>();
        GuardarMemoria guardarMemoria = new GuardarMemoria();
        int pagina = 0;
        int cantidad = 50;
        bool cargando = false;
        private FormMenu formMenuRef;
        ConsultasSQL consulta;
        PermisosAplicacion permisosAplicacion = new PermisosAplicacion();
        public VistaAdministrador()
        {
            InitializeComponent();
            formMenuRef = new FormMenu();
            GridPermisos.CellContentClick += GridPermisos_CellContentClick;
            GridPermisos.Refresh();
            GridPermisos.CellValueChanged += GridPermisos_CellValueChanged;
            GridPermisos.CurrentCellDirtyStateChanged += GridPermisos_CurrentCellDirtyStateChanged;
            GridBD.AutoGenerateColumns = true;
            consulta = new ConsultasSQL();
            cargarAPI = new CargarAPI();
            PBcargaCartas.Minimum = 0;
            PBcargaCartas.Visible = false;
            ocultarDetalles();
            PanelDetalles();
            CargarPermisos();
  

        }
        void CargarPermisos()
        {
            cargando = true;

            GridPermisos.Dock = DockStyle.Fill;
            GridPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPermisos.AutoGenerateColumns = false;
            GridPermisos.RowHeadersWidth = 150;

            GridPermisos.Rows.Clear();
            GridPermisos.Rows.Add(5);

            string[] permisos = {
        "Usuario Guardar",
        "Usuario Borrar", 
        "Modificar Base de datos",
        "Añadir cartas a la base de datos",
        "Borrar Cartas de la base de datos"
    };

            for (int i = 0; i < permisos.Length; i++)
            {
                GridPermisos.Rows[i].HeaderCell.Value = permisos[i];
                GridPermisos.Rows[i].Tag = permisos[i];
            }

            guardarMemoria.Cargar(GridPermisos);

            cargando = false;
          
        }
        private async Task CargarDatosBD()
        {
            try
            {
                ConsultasSQL consultas = new ConsultasSQL();

                var dt = await Task.Run(() =>
                    consultas.EjecutarConsulta(
                        "SELECT id, nombre, email, rol, fecha_registro FROM usuarios"
                    )
                );

                GridBD.AutoGenerateColumns = true;
                GridBD.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error BD: " + ex.Message);
            }
        }
        private async Task CargarCartas()
        {
            PanelCartasAdmin.AutoScroll = true;
            cartas = await cargarAPI.ObtenerAPI();

            cartas = await Task.Run(() => cartas.Where(x =>
                !string.IsNullOrWhiteSpace(x.Name) &&
                x.Attack.HasValue &&
                x.Health.HasValue &&
                !string.IsNullOrWhiteSpace(x.Type) &&
                !string.IsNullOrWhiteSpace(x.Id)
            ).ToList());



            pagina = 0;

            await MostrarPagina();
        }
        private async Task MostrarPagina()
        {
            int cantidad = 20;
            int cartasPorFila = 4;

            int anchoCarta = 160;
            int altoCarta = 220;
            int espacio = 20;

            PanelCartasAdmin.SuspendLayout();
            PanelCartasAdmin.Controls.Clear();


            var grupo = cartas
                .Skip(pagina * cantidad)
                .Take(cantidad)
                .ToList();

            int contador = 0;

            foreach (var datos in grupo)
            {
                Carta carta = new Carta(this);

                await carta.CargarCarta(datos);

                int columna = contador % cartasPorFila;
                int fila = contador / cartasPorFila;

                int x = columna * (anchoCarta + espacio);
                int y = fila * (altoCarta + espacio);

                carta.Location = new Point(x, y);

                PanelCartasAdmin.Controls.Add(carta);

                contador++;
            }

            PanelCartasAdmin.ResumeLayout();

        }
        private async void VistaAdministrador_Load(object sender, EventArgs e)
        {
            permisosAplicacion.ActualizarPermisos(this, formMenuRef);


            GridBD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GridBD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            await Task.WhenAll(
               CargarCartas(),
               CargarDatosBD()

            );
            PBcargaCartas.Visible = true;
            LBLcargaCartas.Text = $"Carga Completa";
            await Task.Delay(2000);
            PBcargaCartas.Visible = false;
            LBLcargaCartas.Visible = false;
            permisosAplicacion.ActualizarPermisos(this, formMenuRef);

        }

        private async void BTNsiguiente_Click(object sender, EventArgs e)
        {
            PBcargaCartas.Value = 0;

            if ((pagina + 1) * cantidad < cartas.Count)
            {
                pagina++;
                await MostrarPagina();
            }
        }

        private async void BTNanterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina--;
                await MostrarPagina();
            }
        }
        public void ocultarDetalles()
        {
            LBLnombreCarta.Visible = false;
            LBLvida.Visible = false;
            LBLataque.Visible = false;
            LBLtipo.Visible = false;
            LBLcoste.Visible = false;
            LBLraza.Visible = false;
            LBLclase.Visible = false;
            LBLraro.Visible = false;
        }

        private void ComboTablaBD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboTablaBD.SelectedIndex == 0)
            {
               
                string consultaSQL = consulta.Consulta(0);
                GridBD.DataSource = consulta.EjecutarConsulta(consultaSQL);
          
            }
            if (ComboTablaBD.SelectedIndex == 1)
            {
                string consultaSQL = consulta.Consulta(1);
                GridBD.DataSource = consulta.EjecutarConsulta(consultaSQL);
            }
            PanelDetalles();
        }
        void OcultarPanelDetalles()
        {
            LBLnombre.Visible = false;
            LBLcorreo.Visible = false;
            LBLcontraseña.Visible = false;
            LBLrol.Visible = false;
            TXTnombre.Visible = false;
            TXTcorreo.Visible = false;
            TXTcontraseña.Visible = false;
            ComboRol.Visible = false;
            BTNauxiliar.Visible = false;
            BTNaccion.Visible = false;
        }
     
        void VerPanelDetalles()
        {
            LBLnombre.Visible = true;
            LBLcorreo.Visible = true;
            LBLcontraseña.Visible = true;
            LBLrol.Visible = true;
            TXTnombre.Visible = true;
            TXTcorreo.Visible = true;
            TXTcontraseña.Visible = true;
            ComboRol.Visible = true;
            BTNaccion.Visible = true;
        }
        void PanelDetalles()
        {
            if (string.IsNullOrEmpty(ComboTablaBD.Text))
            {
                OcultarPanelDetalles();
            }
            else if (ComboTablaBD.Text != "")
            {
                VerPanelDetalles();
                switch (ComboTablaBD.SelectedIndex)
                {
                    case 0:
                        BTNaccion.Text = "Guardar";
                        LBLnombre.Text = "Nombre";
                        LBLcorreo.Text = "Correo";
                        LBLcontraseña.Text = "Contraseña";
                        LBLrol.Text = "Rol";
                        BTNauxiliar.Visible = false;
                        break;
                    case 1:

                        BTNaccion.Text = "Agregar admin";
                        LBLnombre.Text = "Id_Usuario";
                        LBLcorreo.Text = "Nivel de acesso";
                        LBLcontraseña.Text = "Nota";
                        LBLrol.Visible = false;
                        ComboRol.Visible = false;
                        BTNauxiliar.Text = "Agregar Nota";
                        BTNauxiliar.Visible = true;
                        break;
                    default:
                        OcultarPanelDetalles();
                        break;
                }
            }
        }
        private void BTNagregar_Click(object sender, EventArgs e)
        {

        }
        private void GridPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (GridPermisos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                GridPermisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                permisosAplicacion.ActualizarPermisos(this, formMenuRef);
            }
        }
        private void GridPermisos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GridPermisos.IsCurrentCellDirty)
            {
                GridPermisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void GridPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (cargando) return;

            if (e.RowIndex < 0) return;
            permisosAplicacion.ActualizarPermisos(this, formMenuRef);
            guardarMemoria.Guardar(GridPermisos);
        }
            private void BTNaccion_Click(object sender, EventArgs e)
        {
            if (BTNaccion.Text == "Guardar")
            {
                if (string.IsNullOrWhiteSpace(TXTnombre.Text))
                {
                    MessageBox.Show("Por favor ingresa un nombre.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTnombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(TXTcorreo.Text))
                {
                    MessageBox.Show("Por favor ingresa un correo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTcorreo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(TXTcontraseña.Text))
                {
                    MessageBox.Show("Por favor ingresa una contraseña.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTcontraseña.Focus();
                    return;
                }


                if (!TXTcorreo.Text.Contains("@") || !TXTcorreo.Text.Contains("."))
                {
                    MessageBox.Show("Por favor ingresa un correo válido.", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTcorreo.Focus();
                    return;
                }

                string nombre = TXTnombre.Text.Trim();
                string correo = TXTcorreo.Text.Trim();
                string contraseña = TXTcontraseña.Text;
                string rol = ComboRol.SelectedItem?.ToString() ?? "Usuario";
                DateTime fechaRegistro = DateTime.Now;

                AgregarRegistro agregar = new AgregarRegistro();
                agregar.AgregarUsuario(nombre, correo, contraseña, rol, fechaRegistro);

                LimpiarCampos();

                string consultaSQL = consulta.Consulta(0);
                GridBD.DataSource = consulta.EjecutarConsulta(consultaSQL);

            }
            else return;
        
        }

        private void LimpiarCampos()
        {
            TXTnombre.Clear();
            TXTcorreo.Clear();
            TXTcontraseña.Clear();
            TXTnombre.Focus();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            // Limpiar datos guardados
            Properties.Settings.Default.correo = "";
            Properties.Settings.Default.contraseña = "";
            Properties.Settings.Default.recordar = false;
            Properties.Settings.Default.Save();

            // Mostrar login
            Form1 login = new Form1();
            login.Show();

            // Cerrar formulario actual
            this.Close();
        }

        private void GridBD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ComboTablaBD.Text == "")
            {
                MessageBox.Show("Selecciona una tabla para mostrar los detalles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ComboTablaBD.Enabled)
            {
                if (ComboTablaBD.SelectedIndex == 0)
                {       
                    BTNauxiliar.Text = "Editar";

                    BTNauxiliar.Visible = true;

                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow fila = GridBD.Rows[e.RowIndex];
                        TXTnombre.Text = fila.Cells["nombre"].Value.ToString();
                        TXTcorreo.Text = fila.Cells["email"].Value.ToString();
                        ComboRol.SelectedItem = fila.Cells["rol"].Value.ToString();
                    }
                }
            }
            else MessageBox.Show("No tienes permisos de Modificar la bases de datos+", "Información");
        }

        private void BTNauxiliar_Click(object sender, EventArgs e)
        {
            if (BTNauxiliar.Text == "Editar" )
            {
                string consultaSQL = consulta.Consulta(1);
                consulta.EjecutarConsulta(consultaSQL);
                MessageBox.Show("Cambio Exitoso", "Exito");
                string consultaSQL2 = consulta.Consulta(0);
                GridBD.DataSource = consulta.EjecutarConsulta(consultaSQL2);

            }
        }
    }   
}