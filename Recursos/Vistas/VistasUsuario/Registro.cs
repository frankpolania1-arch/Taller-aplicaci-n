using FPETDesktopApp.Recursos.Controles;
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
            BTNregistroNuevo.Enabled = false;
            TXTcontraseña.PasswordChar = '*';
        }

        private async void BTNregistroNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                BTNregistroNuevo.Enabled = false;
                Autentificar_Campos.Autentificar_Campos Acampos = new Autentificar_Campos.Autentificar_Campos();
           
                string correo = TXTcorreo.Text.Trim();
                string nombreUsuario = TXTusuario.Text.Trim();

                // Código aleatorio de autenticación
                Random rd = new Random();
                codigo = rd.Next(100000, 999999);

                // Crear instancia del servicio
                Servicios.Mensajeria.Gmail.MensajeriaGmail mensajeria =
                    new Servicios.Mensajeria.Gmail.MensajeriaGmail();

               if(string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(TXTcontraseña.Text)||string.IsNullOrEmpty(ComboRol.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                // Enviar correo usando HTML dinámico
                if (Acampos.IsValidCorreo(TXTcorreo.Text.Trim()))
                {
                    {
                        await mensajeria.EnviarEmail(
                        correo,
                        "Código de verificación",
                        codigo,
                        nombreUsuario);
                        MessageBox.Show("Correo enviado correctamente.");


                    }
                } else if (Acampos.IsValidCorreo(TXTcorreo.Text.Trim())==false)
                {
                    BTNregistroNuevo.Enabled = true;
                    return;
                }


                    AutentificacionRegistro Ar = new AutentificacionRegistro();
                Ar.rol = ComboRol.Text;
                Ar.nombre = nombreUsuario;
                Ar.correo = correo;
                Ar.contraseña = TXTcontraseña.Text;
                Ar.codigoAutentificacion = codigo; 
                Ar.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void CKterminos_CheckedChanged(object sender, EventArgs e)
        {
            if (CKterminos.Checked)
            {
                BTNregistroNuevo.Enabled = true;

            } else BTNregistroNuevo.Enabled = false;
        }

        private void BTNinicio_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void CKmostrar_CheckedChanged(object sender, EventArgs e)
        {

            if (CKmostrar.Checked)
                TXTcontraseña.PasswordChar = '\0';
            else
                TXTcontraseña.PasswordChar = '*';
        }
    }   
}
