using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp09
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aufgabe:
            // Eine Methode schreiben, die vom Benutzer
            // Float-Werte einliest.

            // Eine Schleife aufbauen, die bis Eingabe einer
            // negativen Wert durchläuft und 
            // jedesmal folgenden Text ausgibt:

            // ***
            // Eine Zahl eingeben: 50,3
            // ----
            // Ihre 1. Zahl ist 50,3
            // ***
            // Eine Zahl eingeben: 5,2
            // ----
            // Ihre 2. Zahl ist 5,2
            // ***
            // Eine Zahl eingeben: -1
            // ----
            // Ihre 3. Zahl ist -1
            // ---- ENDE ----
            int counter = 0;
            float floatValue = 1.0F;

            while(floatValue > 0)
            {
                counter++;
                floatValue = FloatEinlesen();
                Console.WriteLine("****");
                Console.WriteLine("Ihre " + counter + ". Zahl ist " + floatValue);
                // continue;
            }
            Console.WriteLine("---- ENDE ----");
        }

        static float FloatEinlesen()
        {
            float negativerwert;
            Console.Write("Einen float Wert eingeben: ");
            negativerwert = float.Parse(Console.ReadLine());
            return negativerwert;
        }

    }
}
