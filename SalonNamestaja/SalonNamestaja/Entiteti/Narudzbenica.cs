using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonNamestaja.Entiteti
{
    public class Narudzbenica
    {
        public String ImeKupca { get; set; }
        public String PrezimeKupca { get; set; }
        public double Racun { get; set; }
        public String AdresaDostave { get; set; }
        public Dictionary<String, double> Porudzbina { get; set; }

        public Narudzbenica()
        {
            Porudzbina = new Dictionary<string, double>();
        }
    }
}
