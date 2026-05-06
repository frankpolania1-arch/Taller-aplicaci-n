using FPETDesktopApp.Recursos.Vistas.Administrador;
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

    public class GuardarMemoria
    {
        static string ruta = "permisos.json";

        public void Guardar(DataGridView grid)
        {
            List<Permisos> lista = new List<Permisos>();

            foreach (DataGridViewRow fila in grid.Rows) // 🔥 CORREGIDO
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.Tag?.ToString() ?? fila.HeaderCell.Value?.ToString();

                if (string.IsNullOrWhiteSpace(nombre))
                    continue;

                lista.Add(new Permisos
                {
                    Nombre = nombre,
                    Usuario = Convert.ToBoolean(fila.Cells["Usuario"].Value),
                    Administrador = Convert.ToBoolean(fila.Cells["Administrador"].Value)
                });
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

            List<Permisos> lista;
            try
            {
                lista = JsonSerializer.Deserialize<List<Permisos>>(json) ?? new List<Permisos>();
            }
            catch
            {
                MessageBox.Show("Error al leer el JSON de permisos");
                return;
            }

            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (fila.IsNewRow) continue;

                // 🔥 Usar Tag en lugar del Header
                string nombre = fila.Tag?.ToString();

                if (string.IsNullOrWhiteSpace(nombre)) continue;

                // 🔥 Búsqueda segura (evita null)
                var permiso = lista.FirstOrDefault(p =>
                    p != null &&
                    !string.IsNullOrWhiteSpace(p.Nombre) &&
                    string.Equals(p.Nombre.Trim(), nombre.Trim(), StringComparison.OrdinalIgnoreCase)
                );

                if (permiso != null)
                {
                    // ✅ Usuario (CheckBox)
                    if (grid.Columns.Contains("Usuario"))
                    {
                        bool valorUsuario = false;

                        try
                        {
                            valorUsuario = Convert.ToBoolean(permiso.Usuario);
                        }
                        catch { }

                        fila.Cells["Usuario"].Value = valorUsuario;
                    }

                    // ✅ Administrador (CheckBox)
                    if (grid.Columns.Contains("Administrador"))
                    {
                        bool valorAdmin = false;

                        try
                        {
                            valorAdmin = Convert.ToBoolean(permiso.Administrador);
                        }
                        catch { }

                        fila.Cells["Administrador"].Value = valorAdmin;
                    }
                }
            }
        }
    }
}
