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
        private string correo;
        private string contraseña;
        bool recuerdo = false;

        public Form1()
        {
            InitializeComponent();
            TXTcontraseña.PasswordChar = '*';
            BTNinicio.Enabled = true;
            VistaRegistro = new FormRegistro();
            Acampos = new Autentificar_Campos.Autentificar_Campos();
        }
        private void BTNinicio_Click(object sender, EventArgs e)
        {
            string rol = login.Login(TXTcorreo.Text, TXTcontraseña.Text);

            if (rol != null)
            {
                MessageBox.Show("Inicio de sesión correcto");

                if (rol == "Administrador")
                {
                    Vadministrador.Show();
                    this.Hide();
                }
                else if (rol == "Jugador")
                {
                    VistaJugador.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
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

        private void CKrecordar_CheckedChanged(object sender, EventArgs e)
        {
            if (CKrecordar.Checked)
            {
                correo = TXTcorreo.Text;
                contraseña = TXTcontraseña.Text;
                recuerdo = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(recuerdo)
            {
                TXTcorreo.Text = correo;
                TXTcontraseña.Text = contraseña;
            }
        }
    }
}
