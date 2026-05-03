using FPETDesktopApp.Recursos.Vistas.Administrador;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_final.Scripts.API;

namespace Trabajo_final.Cartas
{
    public partial class Carta : UserControl
    {
        VistaAdministrador Vadministrador = new VistaAdministrador();
        CargarAPI API = new CargarAPI();
        DatosAPI DatosAPI;
        public Carta()
        {

            InitializeComponent();
            PBheroe.Dock = DockStyle.Fill;
            PBheroe.SizeMode = PictureBoxSizeMode.StretchImage;
            AsignarClick(this);  
        }
        private void AsignarClick(Control control)
        {
            control.Click += PBheroe_Click;

            foreach (Control hijo in control.Controls)
            {
                AsignarClick(hijo);
            }
        }
        public async Task CargarCarta(DatosAPI datos)
        {

            try
            {
                Vadministrador.LBLcargaCartas.Visible = true;
                Vadministrador.LBLcargaCartas.Text = $"Cargando API...";


                var imageBytes = await API.client.GetByteArrayAsync(datos.Image);

                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    PBheroe.Image = System.Drawing.Image.FromStream(ms);
                    this.BackgroundImage = PBheroe.Image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    PBheroe.Visible = false;
                }
                Vadministrador.LBLcargaCartas.Text = $"API cargada";
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void PBheroe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Has hecho clic en la carta!");
            Vadministrador.LBLnombreCarta.Text = "Nombre: " + DatosAPI.Name.ToString();
            Vadministrador.LBLvida.Text = "Vida: ";

        }
    }
}