using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;

            if(a>b)
            {
                Console.WriteLine("a ist größer als b");
                Console.WriteLine("------");
            }

            if(b>a)
                Console.WriteLine("b ist größer als a");

            if (a == b) Console.WriteLine("a und b sind gleich");

            if(a != b) // Wenn a und b ungleich sind
            {
                Console.WriteLine("a und b sind ungleich");
            }
            else // ansonsten
            //{
                Console.WriteLine("abc");
            //}

            if (a == b)
            {
                Console.WriteLine();
            }
            //else if (a != b) Console.WriteLine("");
            else
            {
                if (a != b) Console.WriteLine("");
            }

        }
    }
}
