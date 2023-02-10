using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Übung
            Temperatur vom Benutzer einlesen.
            Wasserzustand ausgeben.
            Temperatur = ....
             
            Wasserdampf
            Wasser
            Eis
            */

            float temperatur = 0.0F;
            Console.WriteLine("Aggregatzustände des Wassers bestimmen");
            Console.WriteLine("--------------------------------------");
            Console.Write("Bitte die Wassertemparatur angeben: ");
            temperatur = float.Parse(Console.ReadLine());
            if (temperatur <= 0)
            {
                Console.WriteLine("Das Wasser hat mit einer Temperatur von " + temperatur + " den Aggregatzustand Fest.");
            }
            else if (temperatur > 0 && temperatur <= 100)
            {
                Console.WriteLine("Das Wasser hat mit einer Temperatur von " + temperatur + " den Aggregatzustand Flüssig.");
            }
            else
            {
                Console.WriteLine("Das Wasser hat mit einer Temperatur von " + temperatur + " den Aggregatzustand Gasförmig.");
            }
        }
    }
}
