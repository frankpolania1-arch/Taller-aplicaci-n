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
    }
}
