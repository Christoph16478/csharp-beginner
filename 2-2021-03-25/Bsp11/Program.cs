
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe:
            // Eine Methode schreiben, die
            // Umsatzsteuer eines angegebenen Preises
            // berechtet und zurück liefert.

            // Bsp-Wert: 22.99 Euro exkl. USt
            // Gesucht: USt= ? Euro für 20%
            Console.Write("Bitte geben Sie einen Nettobetrag ein: ");
            double Mehrwertsteuer = double.Parse(Console.ReadLine());
            Console.WriteLine("Der eingegebene Betrag ist " + Mehrwertsteuer + " Euro");
            Console.WriteLine("Die daraus berechnete 20 %ige Mehrwertsteuer ist " + UmsatzsteuerBerechnen(Mehrwertsteuer));
            // UmsatzsteuerBerechnen(Mehrwertsteuer);
        }

        static double UmsatzsteuerBerechnen(double nettobetrag)
        {
            const double mwst = 0.20; // 20 % Ust
            double ust = nettobetrag * mwst;
            return ust;
        }
    }
}
