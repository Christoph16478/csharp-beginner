using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp07
{
    public class Produkt
    {
        public string Name { get; set; }
        public float Menge { get; set; }
        public double EinzelPreis { get; set; }


        // Konstruktor-Aufruf OHNE Parameter
        public Produkt()
        {

        }

        // Konstruktor-Aufruf mit Parameter
        public Produkt(string name, float menge, double einzelPreis)
        {
            Name = name;
            Menge = menge;
            EinzelPreis = einzelPreis;
        }

        public override string ToString()
        {
            return $"{Name};{Menge};{EinzelPreis}";
        }
    }
}
