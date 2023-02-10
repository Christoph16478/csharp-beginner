using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe
            // (1.) Eine Methode schreiben, die die Fläche
            // eines Kreises berechnet und das Ergebnis
            // zurück schickt.

            // (2) Eine weitere Methode schreiben, die
            // den Radius vom Benutzer einliest.

            // In der Main-Methode sollen sie aufgerufen
            // und Ergebnisse ausgegeben werden.
            double radius = RadiusEinlesen();
            Console.WriteLine("---- Berechnung der Fläche eines Kreises ----");
            Console.WriteLine("Die Fläche des Kreises beträgt: " + FlaecheBerechnen(radius));
        }
        static double FlaecheBerechnen(double eingelesenerradius)
        {
            double A = (Math.PI * Math.Pow(eingelesenerradius, 2));
            return A;
        }

        static double RadiusEinlesen()
        {
            double r;
            Console.Write("Bitte einen Radius angeben: ");
            r = double.Parse(Console.ReadLine());
            return r;
        }
    }
}
