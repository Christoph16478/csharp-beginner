using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Übung
            // Fläche eines Kreises berechnen.
            // Radius vom Benutzer einlesen,
            // berechnen und ausgeben.
            // A = r * r * pi

            float r;
            double pi = Math.PI;
            Console.WriteLine("Herzlich willkommen zur Berechung der Fläche eines Kreises");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Bitte geben Sie den Radius des Kreises an: ");
            r = float.Parse(Console.ReadLine());
            double A = Math.Pow(r, 2) * pi;
            Console.WriteLine("Die Fläche des Kreises beträgt " + A);

        }
    }
}
