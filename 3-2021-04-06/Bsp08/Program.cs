using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp08
{
    class Program
    {
        static void Main(string[] args)
        {

            // Personen Verwalten
            // CSV Auslesen
            // liste ändern
            // in eine CSV Datei speichern
            // ManagerKlassen einsetzen

            string derInhalt = DateiManager.DateiLesen(@"D:\meineDateien\Personen1.csv");
            //Console.WriteLine(derInhalt);

            List<string[]> liste = CsvManager.PersonenLaden(derInhalt);
            //string[] abc = { "max", "erika" };

            Console.WriteLine(" ---- Liste1 ----- ");
            foreach (var eintrag in liste)
            {
                Console.WriteLine(eintrag[0] + " " + eintrag[1]);
            }

            string[] neuerEintrag = { "Friedrich", "Musterbruder", "1960" };
            liste.Add(neuerEintrag);

            Console.WriteLine(" ---- Liste2 ----- ");
            foreach (var eintrag in liste)
            {
                Console.WriteLine(eintrag[0] + " " + eintrag[1]);
            }

            Console.WriteLine(" ---- Liste3 ----- ");

            string derNeueInhalt = CsvManager.Personen2Text(liste);
            Console.WriteLine(derNeueInhalt);

            DateiManager.DateiSchreiben(@"D:\meineDateien\Personen2.csv", derNeueInhalt);


        }
    }
}
