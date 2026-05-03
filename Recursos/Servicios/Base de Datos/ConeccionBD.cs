using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Servicios.Base_de_Datos
{
    public class ConeccionBD
    {
        private string cadena = "server=localhost;database=BDarena;user=root;password=;";
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
