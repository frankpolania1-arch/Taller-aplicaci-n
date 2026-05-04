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
        public int? Cost { get; set; }
        public string Type { get; set; }
        public string rarity { get; set; }
        public string race { get; set; }
        public string cardClass { get; set; }
        public string Img { get; set; }
        public string Text { get; set; }
    }
}
