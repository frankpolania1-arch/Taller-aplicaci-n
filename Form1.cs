using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autentificar_Campos;
using FPETDesktopApp.Recursos.Controles.Base_de_datos.Consultas;
using FPETDesktopApp.Recursos.Vistas;
using FPETDesktopApp.Recursos.Vistas.Administrador;
using FPETDesktopApp.Recursos.Vistas.Jugador;

namespace FPETDesktopApp
{
    public partial class Form1 : Form
    {
        FormRegistro VistaRegistro;
        FormMenu VistaJugador = new FormMenu();
        VistaAdministrador Vadministrador = new VistaAdministrador();   
        InicioSesion sesion = new InicioSesion();
        InicioSesion login = new InicioSesion();
        Autentificar_Campos.Autentificar_Campos Acampos;
         public string correo;
        public string contraseña;
        public bool recordar = false;
       
        public Form1()
        {
          
            InitializeComponent();
            TXTcontraseña.PasswordChar = '*';
            BTNinicio.Enabled = true;
            this.Shown += Form1_Shown;
            VistaRegistro = new FormRegistro();
            Acampos = new Autentificar_Campos.Autentificar_Campos();
        }
    
        private void CKmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CKmostrar.Checked)
                TXTcontraseña.PasswordChar = '\0';
            else
                TXTcontraseña.PasswordChar = '*';
        }
    
        private void BTNregistro_Click(object sender, EventArgs e)
        {           
            VistaRegistro.Show();
            this.Hide();
        }


        private async void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.recordar)
            {
                TXTcorreo.Text = Properties.Settings.Default.correo;
                TXTcontraseña.Text = Properties.Settings.Default.contraseña;
                CKrecordar.Checked = true;

                await Task.Delay(100); // 🔥 importante

                BTNinicio.PerformClick();
            }
        }
        private void BTNinicio_Click(object sender, EventArgs e)
        {
            string rol = login.Login(TXTcorreo.Text.Trim(), TXTcontraseña.Text.Trim());

            if (rol == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            if (CKrecordar.Checked)
            {
                Properties.Settings.Default.correo = TXTcorreo.Text.Trim();
                Properties.Settings.Default.contraseña = TXTcontraseña.Text.Trim();
                Properties.Settings.Default.recordar = true;
            }
            else
            {
                Properties.Settings.Default.correo = "";
                Properties.Settings.Default.contraseña = "";
                Properties.Settings.Default.recordar = false;
            }

            Properties.Settings.Default.Save();

            if (rol == "Administrador")
                Vadministrador.Show();
            else if (rol == "Jugador")
                VistaJugador.Show();

            this.Hide();
        }
    }
}
