using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp01
{
    class Person
    {
        // Eigenschaften

        // Wie kann ich eine Eigenschaften erstellen?
        // prop TAB TAB
        public string Name { get; set; }
        // Eigenschaften werden groß geschrieben

        // Kürtzere Schreibweise
        //public int Alter { get; set; }
        // Lange: propfull TAB TAB

        private int _Alter;

        public int Alter
        {
            get
            {
                return _Alter;
            }
            set
            {
                if (value >= 0 && value<=120)
                {
                    _Alter = value;
                }
                else
                {
                    Console.WriteLine(" ERROR! Ungültige Wertzuweisung");
                }
            }
        }
        // Strg + K, D  ----> automaschites Ausrichtung



        // Methoden
        // Wenn nichts angegeben ist, wird die Methode private !!!
        // Zugriffsmodifizierer: private, public
        public void SagHallo()
        {
            Console.WriteLine("Hallo Klasse");
        }

        public void SagHallo2()
        {
            Console.WriteLine("Hallo. Ich bin " + Name);
        }

        public void SagAlter()
        {
            Console.WriteLine($"Ich bis {Alter}");
        }

        // internal??? Zugriffsmodifizierer
        internal void Infos()
        {
            Console.WriteLine("--------------");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Alter : {Alter}");
        }

    }
}
