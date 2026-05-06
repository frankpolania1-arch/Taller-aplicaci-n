using FPETDesktopApp.Recursos.Vistas.Administrador;
using FPETDesktopApp.Recursos.Vistas.Jugador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Controles.PermisosAplicacion
{
    public class PermisosAplicacion
    {
        // ✅ MODIFICADO: Recibe las instancias como parámetros
        public void ActualizarPermisos(VistaAdministrador vadmin, FormMenu vjugador)
        {
            var grid = vadmin.GridPermisos;

            if (grid.Rows.Count >= 5)
            {
                // 🔥 FILA 0 → Usuario Guardar
                if (grid.Rows[0].Cells["Usuario"].Value != null)
                {
                    bool valor = Convert.ToBoolean(grid.Rows[0].Cells["Usuario"].Value);
                    vjugador.BTNguarda.Enabled = valor;
                }
                else
                {
                    vjugador.BTNguarda.Enabled = false;
                }

                // 🔥 FILA 1 → Usuario Borrar
                if (grid.Rows[1].Cells["Usuario"].Value != null)
                {
                    bool valor = Convert.ToBoolean(grid.Rows[1].Cells["Usuario"].Value);
                    vjugador.BTNborra.Enabled = valor;
                }
                else
                {
                    vjugador.BTNborra.Enabled = false;
                }

                // 🔥 FILA 2 → Admin (Combo)
                if (grid.Rows[2].Cells["Administrador"].Value != null)
                {
                    bool valor = Convert.ToBoolean(grid.Rows[2].Cells["Administrador"].Value);
                    vadmin.ComboTablaBD.Enabled = valor;
                }
                else
                {
                    vadmin.ComboTablaBD.Enabled = false;
                }
                if (grid.Rows[3].Cells["Administrador"].Value != null)
                {
                    bool valor = Convert.ToBoolean(grid.Rows[3].Cells["Administrador"].Value);
                    vadmin.BTNagregar.Enabled = valor;
                }
                else
                {
                    vadmin.BTNagregar.Enabled = false;
                }
                if (grid.Rows[4].Cells["Administrador"].Value != null)
                {
                    bool valor = Convert.ToBoolean(grid.Rows[4].Cells["Administrador"].Value);
                    vadmin.BTNborrar.Enabled = valor;
                }
                else
                {
                    vadmin.BTNborrar.Enabled = false;
                }
            }
            else
            {
                vjugador.BTNguarda.Enabled = false;
                vjugador.BTNborra.Enabled = false;
                vadmin.ComboTablaBD.Enabled = false;
                vadmin.BTNagregar.Enabled = false;
                vadmin.BTNborrar.Enabled = false;
            }
        }
    }
}