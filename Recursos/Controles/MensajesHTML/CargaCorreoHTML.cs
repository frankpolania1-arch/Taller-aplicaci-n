using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Html;

namespace FPETDesktopApp.Recursos.Controles.MensajesHTML
{
    internal class CargaCorreoHTML
    {
        public string ruta;

        public CargaCorreoHTML()
        {
            ruta = Path.Combine(
                Application.StartupPath,
                "Datos",
                "Vistas_HTML",
                "VistaCorreo.HTML"
            );
        }
    }
}
