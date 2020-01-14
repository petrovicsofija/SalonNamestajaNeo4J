using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Soba
    {
        public String tipProstorije { get; set; }
        public int stanjeNaLageru { get; set; }
        public List<Deo> delovi { get; set; }
        public Soba()
        {
            delovi = new List<Deo>();
        }
    }
}

