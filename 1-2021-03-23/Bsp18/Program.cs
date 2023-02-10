using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int wert1 = 1;
            float wert2 = 2.8f;

            int a;
            int b;

            a = (int)wert2; // Casting
            b = Convert.ToInt32(wert2);

            Console.WriteLine(wert2);
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
