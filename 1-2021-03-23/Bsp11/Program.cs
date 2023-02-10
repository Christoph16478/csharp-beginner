using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eingaben von Zahlenwerten

            int zahl1; // den Wert für zahl1 vom Benuter einlesen

            Console.WriteLine("Bitte eine Zahl eingeben");
            // zahl1 = Console.ReadLine(); // FEHLER: string --> int geht nicht! 

            // vom String in eine andere Datentyp 
            // nennt man PARSEN!
            zahl1 = int.Parse(Console.ReadLine());

            zahl1 = zahl1 + 2;

            Console.WriteLine(zahl1);

        }
    }
}
