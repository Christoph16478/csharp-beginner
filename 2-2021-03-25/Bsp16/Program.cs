using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Übung
            // Eine Methode schreiben, die
            // von einem angegebenen String 
            // (zB Preis und Währung) die Zahl
            // extrahiert zurückgibt. Bsp: "ca. 220 Euro"

            string angabe = "ca. 220 Euro";
            int ergebnis = Extrachieren(angabe);
            Console.WriteLine("Ergebnis = " + ergebnis);

        }

        static int Extrachieren(string text)
        {
            string zwischenSpeicher = "";
            for (int i = 0; i < text.Length; i++)
            {
                char meinZeichen = text[i];
                int meinWert = (int)meinZeichen;
                // 48-57
                if(meinWert >= 48 && meinWert <= 57)
                {
                    zwischenSpeicher += meinZeichen; // Verkettung
                }
                // Console.WriteLine(i + " " + meinZeichen + " " + meinWert);
            }
            // Console.WriteLine("ZwischenSpeicher = " + zwischenSpeicher);
            
            int meineZahl = int.Parse(zwischenSpeicher);

            return meineZahl;
        }
    }
}
