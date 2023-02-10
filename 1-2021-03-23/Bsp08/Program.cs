using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp08
{
    class Program
    {
        static void Main(string[] args)
        {
            // string ist ein Datentyp für Zeichenketten (Texte)
            string name = "Felix";
            string personName = "Max Mustermann";

            //string PERSONENNAME2 = "";

            // Grüne Unterringelung: Variable wird nicht verwendet

            Console.WriteLine("Hallo " + name);

            personName = "Hallo " + personName;
            Console.WriteLine(personName);



        }
    }
}
