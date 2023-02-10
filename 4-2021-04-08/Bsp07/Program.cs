using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp07
{
    class Program
    {
        static void Main(string[] args)
        {

            // Listen Erstellen

            // Einkaufsliste

            // Es gibt 3 Instantierungsmöglichkeiten

            // Möglichkeit 1
            Produkt produkt1 = new Produkt(); // Konstruktor-Aufruf OHNE Parameter
            produkt1.Name = "Obst";
            produkt1.EinzelPreis = 2;
            produkt1.Menge = 1;

            // Möglichkeit 2
            Produkt produkt2 = new Produkt("Gemüse", 5, 2); // Konstruktor-Aufruf mit Parameter

            // Möglichkeit 3
            Produkt produkt3 = new Produkt
            {
                Name = "Reinigungsmittel",
                Menge = 1,
                EinzelPreis = 4
            };

            List<string> liste1 = new List<string>();
            liste1.Add("Max");
            liste1.Add("Erika");

            List<Produkt> produktListe = new List<Produkt>();
            produktListe.Add(produkt1);
            produktListe.Add(produkt2);
            produktListe.Add(produkt3);
            // Möglichkeit 4
            produktListe.Add(new Produkt { Name = "Heft", Menge = 1, EinzelPreis = 8 });

            foreach (var einProdukt in produktListe)
            {
                //Console.WriteLine(einProdukt.Name);                
                Console.WriteLine(einProdukt.ToString());
            }

            // Mit einer List ... ---> Lambda Ausdrücke
            // Sortierungen
            // Suche durchführen
            // Filterungen durchführen
            // Berechnungen durchführen
            // Min und Max Werte ermitteln 

            // die Liste in WinForm in einer GridView darstellen. Wie im Excel


        }
    }
}
