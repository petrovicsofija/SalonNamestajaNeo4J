using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Namestaj
    {
        public String opis { get; set; }
        public String dimenzija { get; set; }
        public double cena { get; set; }
        public int stanjeNaLageru { get; set; }
        public String ime { get; set; }
        public Deo deo { get; set; }
        public Deo jeDeo(Soba s, String uloga)
        {
            deo = new Deo();
            deo.soba = s;
            deo.uloga = uloga;

            return deo;
        }
    }
}
