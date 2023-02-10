using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    class Program
    {
        static void Main(string[] args)
        {
            // JsonErstellen();

            JsonLaden();
        }

        private static void JsonLaden()
        {
            string inhalt = File.ReadAllText(@"C:\tmp\meinJson.txt");
            List<Person> dieListAusDerDatei = JsonConvert.DeserializeObject<List<Person>>(inhalt);
            PersonenAusgeben(dieListAusDerDatei);
        }

        private static void JsonErstellen()
        {
            // NewtonSoft
            // JSON
            List<Person> dieListe = GetPersonen();

            //JSON erstellen
            string JsonText = JsonConvert.SerializeObject(dieListe);
            // Serialisieren = Objekte in Text umwandeln
            Console.WriteLine(JsonText);

            // Wowerden JSON pakete ingesetzt.
            // Faccebook, ... APPs, die mit APIs arbeiten.
            // APP <------- JSON ------> Server
            // Vorteil: Port 80

            File.WriteAllText(@"C:\tmp\meinJson.txt", JsonText);
        }

        private static void PersonenAusgeben(List<Person> meineListe)
        {
            foreach (var eintrag in meineListe)
            {
                Console.WriteLine($"{eintrag.Personalnummer};{eintrag.Anrede};{eintrag.Vorname};{eintrag.Nachname};{eintrag.GebJahr}");
            }

        }

        private static List<Person> GetPersonen()
        {
            List<Person> personenListe = new List<Person>();

            personenListe.Add(new Person
            {
                Personalnummer = 1,
                Anrede = "Herr",
                Vorname = "Max",
                Nachname = "Mustermann",
                GebJahr = 1898
            });

            personenListe.Add(new Person
            {
                Personalnummer = 2,
                Anrede = "Frau",
                Vorname = "Erika",
                Nachname = "Musterfrau",
                GebJahr = 1999
            });

            personenListe.Add(new Person
            {
                Personalnummer = 3,
                Anrede = "Herr",
                Vorname = "Felix",
                Nachname = "Mustersohn",
                GebJahr = 2001
            });

            personenListe.Add(new Person
            {
                Personalnummer = 4,
                Anrede = "Herr",
                Vorname = "Friedrich",
                Nachname = "Musteronkel",
                GebJahr = 1956
            });

            return personenListe;
        }
    }
}
