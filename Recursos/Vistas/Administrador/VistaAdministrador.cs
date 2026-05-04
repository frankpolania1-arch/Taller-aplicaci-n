using FPETDesktopApp.Recursos.Controles;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int pagina = 0;
        int cantidad = 50;
        ConsultasSQL consulta;
        public VistaAdministrador()
        {
            InitializeComponent();
            ocultarDetalles();
            GridPermisos.AutoGenerateColumns = false;
            GridBD.AutoGenerateColumns = true;
            consulta = new ConsultasSQL();
            cargarAPI = new CargarAPI();
            GridPermisos.RowHeadersWidth = 100;
            GridPermisos.Rows.Add();
            GridPermisos.Rows.Add();
            GridPermisos.Rows[0].HeaderCell.Value = "Guardar";
            GridPermisos.Rows[1].HeaderCell.Value = "Borrar";
            PBcargaCartas.Minimum = 0;
            PBcargaCartas.Visible = false;

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
                Carta carta = new Carta(this); // 🔥 PASAS EL FORM

                await carta.CargarCarta(datos); // 🔥 AQUÍ SE ASIGNA datosCarta

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
            Console.WriteLine("tab index " + ComboTablaBD.SelectedIndex);
            if (ComboTablaBD.SelectedIndex == 0)
            {
                string consultaSQL = consulta.Consulta(0);
                MessageBox.Show(consultaSQL);
                GridBD.DataSource = consulta.EjecutarConsulta(consultaSQL);
                Console.WriteLine("tab index" + ComboTablaBD.SelectedIndex);
            }
        }

        private void BTNagregar_Click(object sender, EventArgs e)
        {

        }
    }
}
