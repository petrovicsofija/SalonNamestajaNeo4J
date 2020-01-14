using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Tehnika
    {
        public double cena { get; set; }
        public String opis { get; set; }
        public String dimenzija { get; set; }
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

        public override string ToString()
        {
            return string.Format("{0} i cena je: {1} eur", opis, cena);
        }
    }
}
