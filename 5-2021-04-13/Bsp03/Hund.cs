using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    public class Hund : Lebewesen // Hier verwendet also die Vererbung statt
    {
        //public string Name { get; set; }

        //public int GebJahr { get; set; }

        public void Bellen()
        {
            Console.WriteLine("WuffWuff");
        }
    }
}
