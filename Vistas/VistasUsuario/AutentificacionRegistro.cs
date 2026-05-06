using FPETDesktopApp.Recursos.Vistas.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FPETDesktopApp.Recursos.Controles.Base_de_datos.Consultas;
using FPETDesktopApp.Recursos.Vistas.Jugador;

namespace FPETDesktopApp.Recursos.Vistas
{
    public partial class AutentificacionRegistro : Form
    {
        public int codigoAutentificacion;
        FormRegistro formRegistro;
        FormMenu vistaUsuario;
        VistaAdministrador Vadministrador;
        public string rol;
        public string nombre;
        public string correo;
        public string contraseña;
        AgregarRegistro agregarRegistro = new AgregarRegistro();

        public AutentificacionRegistro()
        {
            InitializeComponent();
            formRegistro = new FormRegistro();
            Vadministrador = new VistaAdministrador();
            vistaUsuario = new FormMenu();

        }
        private void BTNautentificar_Click(object sender, EventArgs e)
        {
            
            if (TXTcodigo.Text == codigoAutentificacion.ToString())
            {
                
                agregarRegistro.AgregarUsuario(nombre, correo, contraseña, rol, DateTime.Now);
                MessageBox.Show("Código de autenticación correcto.");
                
                Console.WriteLine(rol + "Hola");
                if (rol == "Administrador")
                {
                    Vadministrador.Show();
                    this.Hide();
                    return;
                }
                else if (rol == "Jugador")
                {
                    // Aquí puedes abrir la vista correspondiente para el jugador
                    MessageBox.Show("Bienvenido, Jugador.");
                    vistaUsuario.Show();
                    this.Hide();
                    return;
                }

            }
            else MessageBox.Show("Código de autenticación incorrecto.", "Alerta");
        }
    }
}
