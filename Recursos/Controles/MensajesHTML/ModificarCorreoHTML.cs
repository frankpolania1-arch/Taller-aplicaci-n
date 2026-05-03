using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPETDesktopApp.Recursos.Controles.MensajesHTML
{

    internal class ModificarCorreoHTML
    {
        public string ModificarHTML(string ruta, int codigoAutentificacion, string nombreUsuario)
        {
            string htmlCorreo = File.ReadAllText(ruta);

            htmlCorreo = htmlCorreo.Replace(
                "{CODIGO_AUTENTIFICACION}",
                codigoAutentificacion.ToString()
            );

            htmlCorreo = htmlCorreo.Replace(
                "{NOMBRE_USUARIO}",
                nombreUsuario
            );

            return htmlCorreo;
        }
    }
}
