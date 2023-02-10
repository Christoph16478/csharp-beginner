using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse Rechteck
            // Abgeleitete Eigenschaften
            // Rechteck (Breite, Hoehe, Pythagoras Diagonale) ---> sqrt(a*a+b*b)

            Rechteck rechteck1 = new Rechteck(5, 10);
            Console.WriteLine(rechteck1.Flaeche);
            // Berechnung findet nur beim Zugriff statt.
            // nicht beim Instazieren.
            // Somit wird die Erstellung des Objektes beschleunigt.
            // Das spart resourcen.
            Console.WriteLine(rechteck1.Umfang);

            

        }
    }
}
