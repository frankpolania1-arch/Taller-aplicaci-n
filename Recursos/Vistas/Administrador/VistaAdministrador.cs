using FPETDesktopApp.Recursos.Controles;
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
            try
            {
                PanelCartasAdmin.AutoScroll = true;

                // 1. Cargar API
                cartas = await cargarAPI.ObtenerAPI();

                if (cartas == null || cartas.Count == 0)
                {
                    MessageBox.Show("No se cargaron cartas desde la API");
                    return;
                }

                // 2. Filtrar (fuera del hilo UI)

                cartas = await Task.Run(() => cartas.Where(x =>
                    !string.IsNullOrWhiteSpace(x.Name) &&
                    x.Attack.HasValue &&
                    x.Health.HasValue &&
                    !string.IsNullOrWhiteSpace(x.Type) &&
                    !string.IsNullOrWhiteSpace(x.Id)
                ).ToList());

                // 3. Reset paginación
                pagina = 0;

                // 4. Mostrar
                await MostrarPagina();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cartas: " + ex.Message);
            }
        }
        private async Task MostrarPagina()
        {
            PBcargaCartas.Visible = true;  
            LBLcargaCartas.Visible = true;
            LBLcargaCartas.Text = $"Cargando cartas...";
            int cantidad = 20;
            int cartasPorFila = 4;

            int anchoCarta = 160;
            int altoCarta = 220;
            int espacioEntreCartas = 20;

            PanelCartasAdmin.SuspendLayout();
            PanelCartasAdmin.Controls.Clear();

            var grupo = cartas
                .Skip(pagina * cantidad)
                .Take(cantidad)
                .ToList();

            if (grupo.Count == 0)
            {
                PanelCartasAdmin.ResumeLayout();
                return;
            }
            var tareas = grupo.Select(async datos =>
            {
                Carta carta = new Carta();
                await carta.CargarCarta(datos);
                return carta;
            }).ToList();

            var cartasCargadas = await Task.WhenAll(tareas);

            int contador = 0;
            PBcargaCartas.Value = 0;

            foreach (var carta in cartasCargadas)
            {
                int columna = contador % cartasPorFila;
                int fila = contador / cartasPorFila;

                int x = columna * (anchoCarta + espacioEntreCartas);
                int y = fila * (altoCarta + espacioEntreCartas);

                carta.Location = new Point(x, y);

                PanelCartasAdmin.Controls.Add(carta);

                contador++;
                PBcargaCartas.Value = (contador * 100) / cartasCargadas.Length;
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
    }
}
