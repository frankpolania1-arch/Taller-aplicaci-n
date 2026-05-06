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

        public string Login(string usuario, string contraseña)
        {
            string consulta = "SELECT rol FROM usuarios WHERE email = @email AND password = @pass LIMIT 1";

            using (MySqlConnection conn = new ConeccionBD().ObtenerConexion())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@email", usuario);
                    cmd.Parameters.AddWithValue("@pass", contraseña);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString(); // retorna el rol
                    }
                    else
                    {
                        return null; // usuario o contraseña incorrectos
                    }
                }
            }
        }
    }
}

