using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp08
{
    class Program
    {
        static void Main(string[] args)
        {

            // Eine Methode schreiben, die vom Benutzer
            // einen INT-Wert einliest und zurück sendet.
            // Benutzerfreundlich bitte!

            // Vorbereiten (Variablen erstellen)
            // int a; // Bezeichnungen sollten aussagekräftig sein!
            int zahl1;
            int zahl2;
            int summe; // aussagekräftige Bezeichnungen !!!!

            // Eingabe 
            zahl1 = ZahlEinlesen();
            zahl2 = ZahlEinlesen();

            // Verarbeitung
            summe = zahl1 + zahl2;

            // Ausgabe
            Console.WriteLine("Summe beträgt " + summe);

        }

        static int ZahlEinlesen()
        {
            int eingabe = 0; // Initialwert

            Console.Write("Eine Zahl eingeben: ");
            eingabe = int.Parse( Console.ReadLine() );

            return eingabe;
        }
    }
}
