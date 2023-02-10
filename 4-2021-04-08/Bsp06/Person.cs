using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp06
{
    public class Person
    {
        public string Name { get; set; }

        private int _Alter;
        public int Alter
        {
            get { return _Alter; }
            set
            {
                if(value>=0)
                {
                    _Alter = value;
                }
                else
                {
                    // Fehler meldung muss aussagekräftig sein!
                    throw new ArgumentException("Alter darf nicht negativ sein", 
                        "Klasse Person bekamm den Wert " + value);
                }
            }
        }



        public void Info()
        {
            Console.WriteLine($"Name: {Name} Alter: {Alter} ");

        }

        // String Ausgabe aus dem Objekt mit override ToString()
        public override string ToString()
        {
            return $"{Name};{Alter}"; // CSV
        }

        //public override string ToString()
        //{
        //    return $"Name: {Name} Alter: {Alter} ";
        //}

    }
}
