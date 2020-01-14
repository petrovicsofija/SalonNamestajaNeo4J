using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Deo
    {
        public string uloga { get; set; }
        public Soba soba { get; set; }
        public Dekoracija dekoracija { get; set; }
        public Namestaj namestaj { get; set; }
        public Tehnika tehnika { get; set; }
        public Rasveta rasveta { get; set; }

    }
}
