using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fehler auswerfen und abfangen

            // try TAB TAB
            try
            {
                Person person1 = new Person();
                person1.Name = "Felix";
                person1.Alter = 10;
                person1.Info();

                //person1.Alter = -2;


                // String Ausgabe aus dem Objekt mit override ToString()
                Console.WriteLine("----------------");
                Console.WriteLine(person1);
                Console.WriteLine("----------------");
                Console.WriteLine(person1.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehlermeldung: " + ex.Message);
                //throw;
            }

        }
    }
}
