using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Vistas.Jugador
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BTNjuego_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Vamos a jugar!"); 
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.correo = "";
            Properties.Settings.Default.contraseña = "";
            Properties.Settings.Default.recordar = false;
            Properties.Settings.Default.Save();

            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
