using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp24
{
    class Program
    {
        static void Main(string[] args)
        {

            //// FOR-Schleife
            //// Begin, Ende und die Schritte kennen!
            //for (int a = 1; a <= 10; a++)
            //{
            //    Console.WriteLine(a);
            //}

            //// von 15 bis 10 rückwerts zählen
            //for (int b = 15; b >= 10; b--)
            //{
            //    // b >= 10 ... solange b >= 10 ist
            //    Console.WriteLine(b);
            //}

            //// von 10 bis 100 um 10er Schritten
            //for(int c=10; c<=100; c+=10)
            //{
            //    // c<=100 .... solange c<=100 ist
            //    // c = c + 10 .... um 10er Schritten
            //    // c+=10 ..... um 10er Schritten
            //    Console.WriteLine(c);
            //}


            // Aufgabe:
            // 3, 6, 9, 12, 15
            for (int a = 3; a <= 15; a+=3)
            {
                Console.Write(a + ", ");
            }
            Console.Write("\n\n");


            // 27; 25; 23; 21; 19; 17;
            for (int b = 27; b >= 15; b -= 2)
            {
                Console.Write(b + "; ");

            }
            Console.Write("\n\n");


            // Aufgabe: 
            // 1; 10; 100; 1000; 10000; 100000
            for (int c = 1; c <= 100000; c *= 10)
            {
                Console.Write(c + "; ");

            }
            Console.Write("\n\n");
        }
    }
}
