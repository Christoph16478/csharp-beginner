using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe
            // Eine Methode schreiben, die die Wörter einer 
            // Zeichenkette untereinander auflist.
            // Bsp: "Es sollte ein schönes Wetter sein heute :)"
            // Ergebnis:
            //Es 
            //sollte 
            //ein 
            //schönes 
            //Wetter 
            //sein 
            //heute 
            //:)
            ListeUntereinander("Es sollte ein schönes Wetter sein heute :)");

            // Aufgabe
            // Eine Methode schreiben, die die Zeichen eines
            // angegebenen Textes in Klein- und Gross-Buchstaben
            // Umwandelt und das Ergenis als String zurück schickt. 
            // Bsp: "Es ist schön Heute"
            // Ergebnis: "eS IST SCHÖN hEUTE"
            string ang = "Es ist schön Heute";
            int erge = Umwandeln(ang);
            Console.WriteLine("Ergebnis = " + erge);

            Console.WriteLine("\n");

            // Aufgabe
            // Eine Methode schreiben, die 
            // aus einem angegebenen Satz nur die Grossbuchstaben herausnimmt, 
            // und als einer Zeichenkette zurück sendet.
            // Bsp: "Der Text hier beinhaltet Klein- und Gross-Buchstaben..."
            // Ergebnis: "DTKGB"
            // NurGrossbuchstaben("Der Text hier beinhaltet Klein- und Gross-Buchstaben...");
            string angabe = "Der Text hier beinhaltet Klein- und Gross-Buchstaben...";
            int ergebnis = NurGrossbuchstaben(angabe);
            Console.WriteLine("Ergebnis = " + ergebnis);

            Console.WriteLine("\n");
        }

        static string ListeUntereinander(string text1)
        {
            return text1.Replace(' ', '\t');
        }

        static int Umwandeln(string text2)
        {
            string zwischenSp = "";
            for (int i = 0; i < text2.Length; i++)
            {
                char meinz = text2[i];
                if (Char.IsLower(meinz))
                {
                    Console.Write(Char.ToUpper(meinz));
                }
                else
                {
                    Console.Write(Char.ToLower(meinz));
                }
            }
            int meinZ = int.Parse(zwischenSp);
            return meinZ;
        }

        static int NurGrossbuchstaben(string text3)
        {
            string zwischenSpeicher = "";
            for (int i = 0; i < text3.Length; i++)
            {
                char meinZeichen = text3[i];
                if (Char.IsUpper(meinZeichen))
                {
                    Console.Write(meinZeichen + ",");
                }
            }
            int meineZahl = int.Parse(zwischenSpeicher);
            return meineZahl;
        }
    }
}
