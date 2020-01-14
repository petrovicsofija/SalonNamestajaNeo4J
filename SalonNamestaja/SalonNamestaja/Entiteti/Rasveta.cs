using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Rasveta
    {
        public String tipRasvete { get; set; }
        public double cena { get; set; }
        public String opis { get; set; }
        public String EnergetskiRazred { get; set; }
        public int stanjeNaLageru { get; set; }
        public Deo deo { get; set; }
        public Deo jeDeo(Soba s, String uloga)
        {
            deo = new Deo();
            deo.soba = s;
            deo.uloga = uloga;

            return deo;
        }
        public String ime { get; set; }


    }
}
