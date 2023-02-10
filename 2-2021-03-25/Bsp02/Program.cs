using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Übung:
            // Wie alt bist du: _
            // einen realistischen Wert einlesen

            int alter;
            do
            {
                // Console.WriteLine() ... mit Zeilenwechsel
                // Console.Write() ... ohne Zeilenwechsel
                Console.Write("Wie alt bist du: ");
                alter = int.Parse(Console.ReadLine());
            } while (alter<=8 || alter>=80);
            // Schleife wiederholen, wenn
            // alter<=8 oder alter>=80
            Console.WriteLine("Danke");


        }
    }
}
