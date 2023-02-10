using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp07
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArbeitenMitDateien();
            //ArbeitenMitPathAngaben();
            //ArbeitenMitOrdnern();

          



        }

        private static void ArbeitenMitOrdnern()
        {
            // Überprüfen, ob der Ordner Existiert
            if (Directory.Exists(@"D:\meineDateien\"))
            {
                Console.WriteLine("Ordner ist vorhanden");
            }
            else
            {
                Console.WriteLine("Ordner ist NICHT vorhanden");
            }

            Console.WriteLine("------");

            // Dateien auflisten
            string[] dateien = Directory.GetFiles(@"D:\meineDateien\");
            Console.WriteLine(String.Join("\n",dateien));

            // Ordner Erstellen
            Directory.CreateDirectory(@"D:\meineDateien\test1\");
            //Directory.CreateDirectory(@"D:\meineDateien\test2\");
            //Directory.CreateDirectory(@"D:\meineDateien\test3\test4\test5\");

            Console.WriteLine("+++++++++");

            // Unterordner auslesen
            string[] unterOrdner = Directory.GetDirectories(@"D:\meineDateien\");
            Console.WriteLine(String.Join("\n", unterOrdner));


        }

        private static void ArbeitenMitPathAngaben()
        {
            string dateiPath = @"D:\meineDateien\versuch1.txt";

            // Dateinamen auslesen
            string dateiName = Path.GetFileName(dateiPath);
            Console.WriteLine(dateiName);

            // Endung auslesen
            string dateiEndung = Path.GetExtension(dateiPath);
            Console.WriteLine(dateiEndung);

            // Path auslesen
            string path = Path.GetDirectoryName(dateiPath);
            Console.WriteLine(path);

            // Stammverzeichnis
            string root = Path.GetPathRoot(dateiPath);
            Console.WriteLine(root);


        }

        private static void ArbeitenMitDateien()
        {
            // Eine Textdatei erstellen
            //File.WriteAllText("D:\\meineDateien\\versuch1.txt", "Hallo Text-Datei");
            //File.WriteAllText(@"D:\meineDateien\versuch1.txt", "Hallo Text-Datei");

            // Lesen einer Textdatei
            //string inhalt = File.ReadAllText(@"D:\meineDateien\versuch2.txt");
            //Console.WriteLine(inhalt);

            if (File.Exists(@"D:\meineDateien\versuch2.txt"))
            {
                Console.WriteLine("Datei ist vorhanden");
            }
            else
            {
                Console.WriteLine("Datei ist NICHT vorhanden");
            }


        }
    }
}
