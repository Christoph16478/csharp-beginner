using System;

namespace Bsp15a
{
    class Program
    {

        static void Main(string[] args)
        {
            // Aufgabe:
            // Eine Methode schreiben, die die Fläche eines Dreiecks berecht.
            // A = a * ha / 2       
            // ha.... Höche von der gegenüber liegender Seite von a
            // Eine weitere Methode schreiben, die nur positive Werte 
            // für a und ha aufnehmen kann.
            // Diese Methoden sollen in der Main-Methode aufgerufen werden.

            int a = PositiveWerte();
            Console.WriteLine("Die Seite 'a' des Dreiecks beträgt " + a);

            int ha = PositiveWerte();
            Console.WriteLine("Bitte die Seite 'ha' des Dreiecks beträgt: " + ha);

            Console.WriteLine("---- Berechnung der Fläche des Dreicks ----");
            Console.WriteLine("Die Fläche des Dreiecks beträgt: " + FlaecheDreieck(a, ha));
        }
        static int FlaecheDreieck(int seite, int hoehe)
        {
            int A = seite * hoehe / 2;
            return A;
        }

        static int PositiveWerte()
        {
            Console.Write("Einen ganzzahligen Wert eingeben: ");
            int positiverwert = int.Parse(Console.ReadLine());
            if (positiverwert > 0)
            {
                Console.WriteLine("Der Wert ist positiv!");
                return positiverwert;
            }
            else
            {
                Console.WriteLine("Das ist ein negativer Wert. Bitte geben Sie einen positiven ein!");
                return PositiveWerte();
            }
        }
    }
}
