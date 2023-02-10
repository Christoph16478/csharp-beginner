using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Folgende Eingabe und Ausgabe realisieren
            // Wie alt bist du: 20
            // Du hast noch 80 Jahre bis 100

            // Vorbereitung


            // Übung
            // Fläche eines Kreises berechnen.
            // Radius vom Benutzer einlesen,
            // berechnen und ausgeben.
            // A = r * r * pi

            // Vorbereitung
            float r = float.Parse(Console.ReadLine());
            double pi = Math.PI;

            // Eingabe
            Console.WriteLine("Herzlich willkommen zur Berechung der Fläche eines Kreises");
            Console.WriteLine("==========================================================\n");
            Console.Write("Bitte geben Sie den Radius des Kreises an: " + r);

            // Verarbeitung (Berechnung)
            double A = Math.Pow(r, 2) * pi;

            // Ausgabe
            Console.WriteLine("Die Fläche des Kreises beträgt " + A + "\n");
            Console.WriteLine("Vielen Dank");


        }
    }
}
