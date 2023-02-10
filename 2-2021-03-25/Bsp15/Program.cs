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
            // Aufgabe:
            // Schreiben Sie eine benutzerfreudliche Methode,
            // die nur die durch 2 teilbare Zahlen aufnimmt
            // und die Eingabe zurück gibt.

            // Benutzer anfordern, dass durch 2 teilbare Zahlen 
            // eingegeben werden soll.
            DurchZweiTeilbar();
        }

        static int DurchZweiTeilbar()
        {
            Console.Write("Weret eingeben, der durch zwei teilbar ist: ");
            int positiverwert = int.Parse(Console.ReadLine());
            if (positiverwert % 2 == 0)
            {
                Console.WriteLine(positiverwert + " ist durch zwei teilbar!");
                return positiverwert;
            }
            else
            {
                Console.WriteLine(positiverwert + " nicht durch 2 ohne Rest teilbar. Bitte erneute Eingabe!");
                return DurchZweiTeilbar();
            }
        }
    }
}
