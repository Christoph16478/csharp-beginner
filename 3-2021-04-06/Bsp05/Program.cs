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

            List<int> liste2 = new List<int>();
            liste2.Add(7);
            liste2.Add(9);
            liste2.Add(2);
            liste2.Add(5);

            Console.WriteLine(String.Join(";",liste2));
            
            int min = liste2.Min();
            Console.WriteLine(min);

            int max = liste2.Max();
            Console.WriteLine(max);

            // Aufgabe: 
            // Methoden schreiben, die MIN und MAX aus einer Liste
            // heraus findet und zurück gibt. Bsp:
            // GetMin()
            // GetMax()


        }
    }
}
