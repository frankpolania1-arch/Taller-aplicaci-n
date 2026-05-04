using FPETDesktopApp.Recursos.Vistas.Administrador;
using MySqlX.XDevAPI;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_final.Scripts.API;

namespace Trabajo_final.Cartas
{
    public partial class Carta : UserControl
    {
        public DatosAPI datosCarta;
        private VistaAdministrador vista;

        // Constructor recibe el formulario
        public Carta(VistaAdministrador v)
        {
            InitializeComponent();
            vista = v;
            PBheroe.SizeMode = PictureBoxSizeMode.StretchImage;
            PBheroe.Dock = DockStyle.Fill;

     

        }
        private static HttpClient client = new HttpClient();

        public async Task CargarCarta(DatosAPI datos)
        {
            datosCarta = datos;

            vista.LBLnombreCarta.Text = datosCarta.Name ?? "Sin nombre";
            vista.LBLataque.Text = datosCarta.Attack?.ToString() ?? "-";
            vista.LBLvida.Text = datosCarta.Health?.ToString() ?? "-";

            try
            {
                // 🔥 usamos el ID para generar la imagen
                string url = $"https://art.hearthstonejson.com/v1/render/latest/esES/256x/{datosCarta.Id}.png";

                var bytes = await client.GetByteArrayAsync(url);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    PBheroe.Image = Image.FromStream(ms);
                }
            }
            catch
            {
                // fallback si falla
                PBheroe.BackColor = Color.DarkGray;
            }

            PBheroe.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public void mostrarDetalles()
        {
            vista.LBLnombreCarta.Visible = true;
            vista.LBLvida.Visible = true;
            vista.LBLataque.Visible = true;
            vista.LBLtipo.Visible = true;
            vista.LBLcoste.Visible = true;
            vista.LBLclase.Visible = true;
            vista.LBLraza.Visible = true;
            vista.LBLraro.Visible = true;
        }
        public void GuardarCarta()
        {
            if (datosCarta == null)
            {
                MessageBox.Show("Error: datosCarta es NULL");
                return;
            }
            // Aquí puedes implementar la lógica para guardar los datos de la carta en la base de datos
            // utilizando los valores de datosCarta y las etiquetas del formulario.
        }



        // Evento click
        private void PBheroe_Click(object sender, EventArgs e)
        {
            if (datosCarta == null)
            {
                MessageBox.Show("Error: datosCarta es NULL");
                return;
            }
        

            vista.LBLnombreCarta.Text = "Nombre: " + datosCarta.Name;
            vista.LBLvida.Text = "Vida: " + (datosCarta.Health?.ToString() ?? "-");
            vista.LBLataque.Text = "Ataque: " + (datosCarta.Attack?.ToString() ?? "-");
            vista.LBLtipo.Text = "Tipo: " + (datosCarta.Type ?? "-");
            vista.LBLcoste.Text = "Coste: " + (datosCarta.Cost?.ToString() ?? "-");
            vista.LBLraza.Text = "Raza" + (datosCarta.race?? "-");
            vista.LBLclase.Text = "Clase " + (datosCarta.cardClass ?? "-");
            vista.LBLraro.Text = "Rareza " + (datosCarta.rarity ?? "-");
            mostrarDetalles();
        }
    }
}