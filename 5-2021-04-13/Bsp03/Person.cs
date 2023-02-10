using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    public class Person : Lebewesen // Eigenschaften werden von Lebewesen an person übergeben
    {
        //public string Name { get; set; }
        //public int GebJahr { get; set; }

        public void Sprechen()
        {
            Console.WriteLine("ich bin " + Name);
        }
    }
}
