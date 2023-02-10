using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    public class Lebewesen //Ein oberklasse von Hund und Person : Den Vorgang der Erstellung einer Oberklasse für die Unterklassen Hund und person nennt man Generalisierung.
    {
        public string Name { get; set; }

        public int GebJahr { get; set; }

        public void Info()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
