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
    public partial class AutentificacionRegistro : Form
    {
        public int codigoAutentificacion;
        FormRegistro formRegistro;
        VistaUsuario vistaUsuario;
        public AutentificacionRegistro()
        {
            InitializeComponent();
            formRegistro = new FormRegistro();
            vistaUsuario = new VistaUsuario();
        }

        private void BTNautentificar_Click(object sender, EventArgs e)
        {
         
            Console.WriteLine("Codigo en autentificacion " + codigoAutentificacion);
            if (TXTcodigo.Text == codigoAutentificacion.ToString())
            {
                MessageBox.Show("Código de autenticación correcto.");
                vistaUsuario.Show();
                this.Hide();
            }
        }
    }
}
