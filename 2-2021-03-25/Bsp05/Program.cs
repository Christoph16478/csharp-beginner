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
            // Aufruf der Methode in der Main-Methode
            Ausgabe();
            Ausgabe2();
            int ergebnis = Quadrat(2);
            Console.WriteLine("Ergebnis = " + ergebnis);

        }

        // Eine Methode:
        static void Ausgabe()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("das ist eine Methode");
        }

        static void Ausgabe2()
        {
            Console.WriteLine("++++++++++++++++++");
        }

        static int Quadrat(int a)
        {
            return a * a;
        }



    }
}
