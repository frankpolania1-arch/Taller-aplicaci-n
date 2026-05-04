using FPETDesktopApp.Recursos.Controles;
using FPETDesktopApp.Recursos.Servicios.GuardarMemoria;
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
        PermisosService permisos = new PermisosService();
        int pagina = 0;
        int cantidad = 50;
        ConsultasSQL consulta;

        public VistaAdministrador()
        {
            InitializeComponent();

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

            GridPermisos.Dock = DockStyle.Fill;
            GridPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPermisos.ColumnHeaderCellChanged += (s, e) => GridPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPermisos.AutoGenerateColumns = false;
            GridPermisos.RowHeadersWidth = 150;
            GridPermisos.Rows.Add(6);
            GridPermisos.Rows[0].HeaderCell.Value = "Usuario Guardar";
            GridPermisos.Rows[1].HeaderCell.Value = "Usuario Borrar";
            GridPermisos.Rows[2].HeaderCell.Value = "Guardar Cartas";
            GridPermisos.Rows[3].HeaderCell.Value = "Modificar Base de datos";
            GridPermisos.Rows[4].HeaderCell.Value = "Añadir cartas a la base de datos";
            GridPermisos.Rows[5].HeaderCell.Value = "Borrar Cartas de la base de datos";
            GridPermisos.Rows[0].Tag = "Usuario Guardar";
            GridPermisos.Rows[1].Tag = "Usuario Borrar";
            GridPermisos.Rows[2].Tag = "Guardar Cartas";
            GridPermisos.Rows[3].Tag = "Modificar Base de datos";
            GridPermisos.Rows[4].Tag = "Añadir cartas a la base de datos";
            GridPermisos.Rows[5].Tag = "Borrar Cartas de la base de datos";
            permisos.Cargar(GridPermisos);
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
                Console.WriteLine("tab index" + ComboTablaBD.SelectedIndex);
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
                        LBLnombre.Text = "Nombre";
                        LBLcorreo.Text = "Correo";
                        LBLcontraseña.Text = "Contraseña";
                        LBLrol.Text = "Rol";
                        BTNauxiliar.Visible = false;
                        break;
                    case 1:
                        LBLnombre.Text = "Id_Usuario";
                        LBLcorreo.Text = "Nivel de acesso";
                        LBLcontraseña.Text = "Nota";
                        LBLrol.Visible = false;
                        ComboRol.Visible = false;
                        BTNaccion.Text = "Guardar";
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

        private void GridPermisos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GridPermisos.IsCurrentCellDirty)
            {
                GridPermisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void GridPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            PermisosService permisos = new PermisosService();
            permisos.Guardar(GridPermisos);

        }
    }
}   