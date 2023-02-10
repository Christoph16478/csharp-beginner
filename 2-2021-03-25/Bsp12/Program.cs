using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            // Methoden Überladung
            a = Summe(1, 2);
            a = Summe(1, 2, 3);
            a = Summe(1, 2, 3, 4);
            a = Summe(1, 2, 3, 4, 5);

            // Compiler kann nur durch die Anzahl und Art der Parameter
            // unterscheiden bzw. zuordnen welcher der Methoden
            // aufgerufen werden sollen. 

        }

        /// <summary>
        /// Summiert die angegebenen Werte
        /// </summary>
        /// <param name="zahl1">zahl1 soll größer als 10 sein</param>
        /// <param name="zahl2">zahl2 soll unter 100 liegen </param>
        /// <returns>Summe der Werte wird zurückgesendet.</returns>
        static int Summe(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        static int Summe(int zahl1, int zahl2, int zahl3)
        {
            return zahl1 + zahl2 + zahl3;
        }

        static int Summe(int zahl1, int zahl2, int zahl3, int zahl4)
        {
            return zahl1 + zahl2 + zahl3 + zahl4;
        }

        static int Summe(int zahl1, int zahl2, int zahl3, int zahl4, int zahl5)
        {
            return zahl1 + zahl2 + zahl3 + zahl4 + zahl5;
        }


    }
}
