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
            // Übung
            // Umfang eines Kreises berechnen.
            // Radius vom Benutzer einlesen,
            // Umfang berechnen und ausgeben.
            // u = 2 * pi * r
            // pi = 3.14

            float r, u, pi = 3.14f;
            Console.WriteLine("=== Umfang eines Kreises ===");
            Console.Write("r = ");
            r = float.Parse( Console.ReadLine() );
            u = 2f * pi * r;
            Console.WriteLine("Umfang beträgt " + u);

        }
    }
}
