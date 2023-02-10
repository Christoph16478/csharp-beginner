using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp08
{
    public class CsvManager
    {
        internal static List<string[]> PersonenLaden(string derInhalt)
        {
            List<string[]> dieListe = new List<string[]>();

            // über den Textinhalt befüllen
            List<string> zeilen = derInhalt.Split('\n').ToList();

            for (int i = 0; i < zeilen.Count; i++)
            {
                //Console.WriteLine( i + " > " + zeilen[i]);

                string dieZeile = zeilen[i];
                // Bsp: dieZeile = "Max;Mustermann;1960"
                string[] spalten = dieZeile.Split(';');

                //string vorname = spalten[0];
                //string nachname = spalten[1];
                //string gebJahr = spalten[2];
                //string[] eigeneArray = { nachname, vorname, gebJahr };
                //dieListe.Add(eigeneArray);
                if (spalten.Length > 1) // Leere Zeilen umgehen
                {
                    dieListe.Add(spalten);
                }

            }

            return dieListe;
        }

        internal static string Personen2Text(List<string[]> personenListe)
        {
            string inhalt = "";

            //foreach (var person in personenListe)
            foreach (string[] person in personenListe)
            {
                //Console.WriteLine(person[0]);

                // Max;Mustermann;1950
                //string eineZeile = person[0] + ";" + person[1] + ";" + person[2];
                string eineZeile = String.Join(";",person);
                //Console.WriteLine(" # " + eineZeile);
                inhalt += eineZeile + "\n";
            }

            return inhalt;
        }
    }
}
