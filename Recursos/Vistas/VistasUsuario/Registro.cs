using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Vistas
{
    public partial class FormRegistro : Form
    {
        public int codigo;
  
        public FormRegistro()
        {
            InitializeComponent();
         
        }

        private async void BTNregistroNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos del usuario
                string correo = TXTcorreo.Text.Trim();
                string nombreUsuario = TXTusuario.Text.Trim();

                // Código aleatorio de autenticación
                Random rd = new Random();
                codigo = rd.Next(100000, 999999);

                // Crear instancia del servicio
                Servicios.Mensajeria.Gmail.MensajeriaGmail mensajeria =
                    new Servicios.Mensajeria.Gmail.MensajeriaGmail();

              
                // Enviar correo usando HTML dinámico
                await mensajeria.EnviarEmail(
                    correo,
                    "Código de verificación",
                    codigo,
                    nombreUsuario
                );

                Console.WriteLine("Codigo generado" + codigo);
                MessageBox.Show("Correo enviado correctamente.");
                AutentificacionRegistro Ar = new AutentificacionRegistro();
                Ar.codigoAutentificacion = codigo; // Pasar el código al formulario de autenticación
                Ar.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }   
}
