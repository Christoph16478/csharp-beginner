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
            // Liste von Objekten
            // Person diePerson = new Person { Personalnummer = 1, Anrede = "Herr", Vorname = "Max", Nachname = "Mustermann", GebJahr = "1898" };

            List<Person> meineListe = GetPersonen();

            PersonenAusgeben(meineListe);

            Console.WriteLine("-------------------------");

            // x => x.GebJahr < 1975
            // Lambda Ausdrücke: Alle Einträge bei denen das Geburtsjahr < 1975 ist.
            List<Person> liste2 = meineListe.Where(x => x.GebJahr < 1975).ToList();
            PersonenAusgeben(liste2);

            Console.WriteLine("-------------------------");

            // Bestimmte Einträge werden haerausgefiltert und in eine andere Liste überführen.
            List<Person> liste3 = meineListe.Where(x => x.Anrede == "Herr").ToList();
            PersonenAusgeben(liste3);

            Console.WriteLine("-------------------------");
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
