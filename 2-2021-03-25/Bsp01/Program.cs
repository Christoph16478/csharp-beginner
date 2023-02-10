using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Eine Schleife erstellen, die
            // folgende Werte ausgibt.
            // -15, -10, -5, 0, 5, 10, 15

            for (int i = -15; i <= 15; i += 5) Console.WriteLine(i);
            */

            /*
            int i = 1;
            for (; i <= 5;)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            /*
            // While-Schleife
            // einzetzen, wenn nur die Bedingung bekannt ist.
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            // Die Schleife wird durchlaufen,
            // solange i <= 5 ist.
            */

            //// Aufgabe:
            //// 21 bis 14 mit 2er Schritten
            //// mit while-Schleife realisieren:
            int countdown = 21;
            while (countdown >= 14)
            {
                Console.WriteLine(countdown);
                countdown -= 2;
            }

            // Aufgabe:
            // von 0 bis wieviel soll ich zählen: 21 <--- Eingabe
            // 0, 1, 2, 3, .... 21
            int eingabe = 0;
            int i = 0;
            Console.Write("Eine Zahl eingeben: ");
            eingabe = int.Parse(Console.ReadLine());
            while (i <= eingabe)
            {
                Console.WriteLine(i);
                i++;
            }

            // Übung:
            // Eine Zahl zw. 1 und 20 eingeben: 25
            // Eine Zahl zw. 1 und 20 eingeben: _
            /*
            int eingabe;
            do
            {
                // die Schleife wird midestens einmal duchlaufen.
                Console.Write("Eine Zahl zw. 1 und 20 eingeben:");
                eingabe = int.Parse( Console.ReadLine() );

            } while (eingabe<1 || eingabe>20); // <--- Schleifbedingung
            // Schleife wiederholen, wenn
            // eingabe<1 oder eingabe>20 ist.
            */
        }
    }
}
