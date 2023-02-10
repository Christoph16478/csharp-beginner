using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp06
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 31;
            int zahl2 = 5;
            int zahl3;

            zahl3 = Addieren(zahl1, zahl2);
            Console.WriteLine("Sie Summe beträgt " + zahl3);

        }

        static int Addieren(int a, int b)
        {
            return a + b;
        }


    }
}
