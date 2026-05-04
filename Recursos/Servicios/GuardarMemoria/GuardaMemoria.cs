using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_final.Scripts.API;

namespace FPETDesktopApp.Recursos.Servicios.GuardarMemoria
{

    public class PermisosService
    {
        static string ruta = "permisos.json";


        public void Guardar(DataGridView grid)
        {
            List<Permisos> lista = new List<Permisos>();

            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (!fila.IsNewRow)
                {
                    lista.Add(new Permisos
                    {
                        Nombre = fila.Tag?.ToString(),
                        Usuario = fila.Cells["Usuario"].Value != null && Convert.ToBoolean(fila.Cells["Usuario"].Value),
                        Administrador = fila.Cells["Administrador"].Value != null && Convert.ToBoolean(fila.Cells["Administrador"].Value)
                    });
                }
            }

            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(ruta, json);
        }

        public void Cargar(DataGridView grid)
        {
            if (!File.Exists(ruta))
                return;

            string json = File.ReadAllText(ruta);

            List<Permisos> lista =
                JsonSerializer.Deserialize<List<Permisos>>(json) ?? new List<Permisos>();

            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.HeaderCell.Value?.ToString();

                var permiso = lista.FirstOrDefault(p => p.Nombre == nombre);

                if (permiso != null)
                {
                    if (grid.Columns.Contains("Usuario"))
                        fila.Cells["Usuario"].Value = permiso.Usuario;

                    if (grid.Columns.Contains("Administrador"))
                        fila.Cells["Administrador"].Value = permiso.Administrador;
                }
            }
        }
    }
}
