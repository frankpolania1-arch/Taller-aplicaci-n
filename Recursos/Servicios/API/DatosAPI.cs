using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final.Scripts.API
{
     public class DatosAPI
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public int? Attack { get; set; }
        public int? Health { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public string CardClass { get; set; }

        public bool Collectible { get; set; }

        public List<string> Mechanics { get; set; } = new List<string>();

        public string Image => $"https://art.hearthstonejson.com/v1/render/latest/esES/256x/{Id}.png";

    }
}
