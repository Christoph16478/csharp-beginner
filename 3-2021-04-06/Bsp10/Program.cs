using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse ist ein Bauplan

            // Auto ist ein Datentyp
            
            Auto abc = new Auto(); 
            // Auto "abc" ist nach dem Bauplan "Auto" instanziert.
            // aufgebaut. erstellt. Das ergibt ein OBJEKT!
            // Das Objekt bekommt den Namen (Referenz) "abc".
            // "abc" ist ein Referenz zum Auto-Objekt.

            // abc. // Methoden und Eigenschaften auflisten.
            
            abc.Farbe = "rot"; // Wert zugewiesen
            abc.Alter = 2;
            abc.Alter = 20;
            abc.Alter = -2; // :(

            abc.Fahren();

            Console.WriteLine(abc.Farbe);


        }
    }
}
