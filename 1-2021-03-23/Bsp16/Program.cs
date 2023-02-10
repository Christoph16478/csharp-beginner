using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl_1 = 2;
            int zahl_2 = 3;

            Console.WriteLine(zahl_1);
            Console.WriteLine(zahl_1+zahl_2);
            Console.WriteLine( (zahl_1+zahl_2)/2 ); // 2 ???

            Console.WriteLine((zahl_1 + zahl_2) / 2f); // 2 ???

            Console.WriteLine( zahl_2 % zahl_1);
            // Modulo

            Console.WriteLine(++zahl_1);
            Console.WriteLine(zahl_1++);

            int ergebnis = 4;
            ergebnis += 3;
            ergebnis /= 3;



        }
    }
}
