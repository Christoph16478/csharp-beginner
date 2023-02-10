using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Celsius in Fahrenheit Umrechnen
            fahrenheit = celsius * 1.8 + 32
            */

            float fahrenheit;
            float celsius;
            Console.WriteLine("Herzlich willkommen zur Umrechnung - Celsius --> Fahrenheit");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Bitte geben Sie die Temperatur in Celsius an: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (float)(celsius * 1.8 + 32);
            Console.WriteLine(celsius + " Grad Celsius sind " + fahrenheit + " Fahrenheit");
        }
    }
}
