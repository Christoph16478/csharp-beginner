using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp02
{
    public class Person
    {
        // Eigenschaften
        //public string Name { get; set; }
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if(value == "")
                {
                    Console.WriteLine(" ERROR ! Name darf nicht leer sein.");
                }
                else
                {
                    _Name = value;
                }
                
            }
        }



        // Methoden
        public void Info()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Name: " + Name);
        }

        // Konstruktor erstellen
        // ctor TAB TAB
        //public Person()
        //{
        //    Name = "neue Person";
        //}

        public Person(string name)
        {
            Name = name;
        }


    }
}
