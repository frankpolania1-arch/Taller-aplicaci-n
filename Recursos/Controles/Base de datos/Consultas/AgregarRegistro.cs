using FPETDesktopApp.Recursos.Servicios.Base_de_Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FPETDesktopApp.Recursos.Controles.Base_de_datos.Consultas
{
    public class AgregarRegistro
    {
        private readonly ConeccionBD coneccion = new ConeccionBD();
        public void AgregarUsuario(string nombre, string correo, string contraseña, string rol, DateTime fecha_registro)
        {
            string consulta = "INSERT INTO usuarios (nombre, email, password, rol, fecha_Registro) VALUES (@nombre, @email, @pass, @rol, @fecha)";

            try
            {
                using (var connection = coneccion.ObtenerConexion())
                {
                    using (var command = new MySqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@email", correo); // ✔ ahora coincide
                        command.Parameters.AddWithValue("@pass", contraseña);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@fecha", fecha_registro); // ✔ mejor como DateTime

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario agregado correctamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
