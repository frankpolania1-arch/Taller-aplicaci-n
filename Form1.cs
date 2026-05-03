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
using FPETDesktopApp.Recursos.Vistas.Jugador;

namespace FPETDesktopApp
{
    public partial class Form1 : Form
    {
        FormRegistro VistaRegistro;
        Form_Jugador VistaJugador = new Form_Jugador();
        InicioSesion sesion = new InicioSesion();
        public Form1()
        {
            InitializeComponent();
            TXTcontraseña.PasswordChar = '*';
            BTNinicio.Enabled = true;
            VistaRegistro = new FormRegistro();
        }
        private void BTNinicio_Click(object sender, EventArgs e)
        {
            bool acceso = sesion.Login(TXTcorreo.Text, TXTcontraseña.Text);
            if (acceso)
            {
                MessageBox.Show("Bienvenido 🎮");
                VistaJugador.Show();
                this.Hide(); // oculta el actual
            }
            else
            {
                MessageBox.Show("Datos incorrectos ❌");
            }
        }
        private void CKmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CKmostrar.Checked)
                TXTcontraseña.PasswordChar = '\0';
            else
                TXTcontraseña.PasswordChar = '*';
        }
        private void CKterminos_CheckedChanged(object sender, EventArgs e)
        {
            if (CKterminos.Checked)
            {
                BTNinicio.Enabled = true;
            }
            else {
                BTNinicio.Enabled = false;
            }
        }
        private void BTNregistro_Click(object sender, EventArgs e)
        {           
            VistaRegistro.Show();
            this.Hide();
        }
    }
}
