using FPETDesktopApp.Recursos.Servicios.Base_de_Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Controles.Base_de_datos.Consultas
{
    internal class InicioSesion
    {
        ConeccionBD coneccionBD = new ConeccionBD();
        ConsultasSQL consultasSQL = new ConsultasSQL();

        public bool Login(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(*) FROM usuarios WHERE email = @usuarios AND password = @contraseña";
            ConeccionBD conexionBD = new ConeccionBD();
            using (MySqlConnection conn = conexionBD.ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@usuarios", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                return resultado > 0;
            }
        }
    }
}

