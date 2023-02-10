using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Boolische Werte true, false
            bool b1;
            bool b2;
            bool ergebnis;

            //// Fall1
            //b1 = false;
            //b2 = true;

            b1 = true;
            b2 = true;

            ergebnis = b1 || b2;
            Console.WriteLine(ergebnis);
            */

            // || ... Oder
            // && ... Und

            // Aufgabe:
            // Erstellen Sie zwei int Variablen mit
            // Namen z1, z2
            // Initialisieren Sie z1 mit 0
            // z2 soll vom User eingegeben werden können

            // Wenn z1 gleich z2 ist, soll auf der
            // Console ausgegeben werden:
            //    "Juhu, z1 ist gleich z2"
            // ist z1 nicht gleich z2, soll auf der 
            // Console ausgegeben weden:
            //    "Schade, z1 ist nicht gleich z2,
            //    z1 ist 0 und z2 " + z2

            int z1 = 0;
            int z2;

            Console.Write("Eine Zahl eingeben: ");
            z2 = int.Parse(Console.ReadLine());

            if (z1 == z2)
            {
                Console.WriteLine("Juhu, " + z1 +  " ist gleich " + z2);
            }
            else
            {
                Console.WriteLine("Schade z1 ist nicht gleich z2, z1 ist " + z1 + " und z2 ist " + z2);
            }
        }
    }
}
