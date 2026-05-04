using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Trabajo_final.Scripts.API;

namespace FPETDesktopApp.Recursos.Servicios.GuardarMemoria
{ //C:\Users\frank\source\repos\FPETDesktopApp\FPETDesktopApp\bin\Debug\Datos\GuardarCartasLocal

    internal class GuardaMemoria
    {
        public string archivo = "cartas_guardadas.json";
        void GuardarJson(DatosAPI datos)
        {
            var rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "GuardarCartasLocal", archivo);

        }
      
    }
}
