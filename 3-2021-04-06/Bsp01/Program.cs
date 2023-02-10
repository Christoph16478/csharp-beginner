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
            string eingabe;
            do
            {
                eingabe = MenuAuswahl();

                //Console.WriteLine("Ihre Eingabe : " + eingabe);

                // Überprüfen
                switch (eingabe)
                {
                    case "1":
                        Flaeche();
                        break;

                    case "2":
                        Umfang();
                        break;
                    case "0":
                        Console.WriteLine("\n\nProgramm wird beendet...\n");
                        break;
                    default:
                        FalscheEingabe();
                        break;
                }


            } while (eingabe != "0");

        }

        private static void FalscheEingabe()
        {
            Console.WriteLine("\n\nERROR! Falsche Eingabe\n\n");
        }

        private static void Umfang()
        {
            Console.WriteLine("\n\nUmfang wird berechnet.\n\n");
        }

        private static void Flaeche()
        {
            Console.WriteLine("\n\nFläche wird berechtet.\n\n");
        }

        private static string MenuAuswahl()
        {
            Console.WriteLine(" === MENÜ ===");
            Console.WriteLine(" 1 - Fläche");
            Console.WriteLine(" 2 - Umfang");
            Console.WriteLine(" 0 - Beenden");
            Console.WriteLine();

            Console.Write("Eingabe : ");
            string eingabe = Console.ReadLine();
            return eingabe;
        }


    }
}
