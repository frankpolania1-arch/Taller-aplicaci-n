using FPETDesktopApp.Recursos.Servicios.Base_de_Datos;
using FPETDesktopApp.Recursos.Vistas.Administrador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Controles
{
    public class ConsultasSQL
    {
        VistaAdministrador Vadministrador;
        ConeccionBD DB = new ConeccionBD();
        string ConsultaSQL = "";

        public static string ConsultaUsuarios = "SELECT * FROM Usuarios";

        public string Consulta(int numeroConsulta)
        { 
            Vadministrador = new VistaAdministrador();
            numeroConsulta = Vadministrador.ComboTablaBD.SelectedIndex;
            switch (numeroConsulta)
            {
                case -1:
                    ConsultaSQL =
                        "SELECT id, nombre, email, rol, fecha_registro FROM usuarios";
                    return ConsultaSQL;

                default:
                    ConsultaSQL = "SELECT * FROM cartas";
                    return MessageBox.Show("No se ha seleccionado ninguna tabla, se mostrará la tabla de usuarios por defecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();

            }
        }
        public DataTable EjecutarConsulta(string consulta)
        {
            if (string.IsNullOrWhiteSpace(consulta))
                throw new Exception("Consulta vacía");

            ConeccionBD conexion = new ConeccionBD();

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                        conn.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();

                adaptador.Fill(dt);
                return dt;
            }
        }
    }
}
