using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp19
{
    class Program
    {
        static void Main(string[] args)
        {
            // $-Operator

            int alter = 20;
            string vorname = "Max";
            string nachname = "Mustermann";
            string ausgabe;

            //ausgabe = "Hallo " + vorname + " " + nachname + " " + alter;

            ausgabe = $"Hallo {vorname} {nachname} {alter}";
            //Console.WriteLine(ausgabe);

            //string datei = "C:\\abc\\meintext.txt";
            string datei = @"C:\abc\meintext.txt";

            //   \n .... Zeilenumbruch

            string vorlage = $@"
Vorname: {vorname}
Nachname: {nachname}
Alter: {alter}
";
            Console.WriteLine(vorlage);

        }
    }
}
