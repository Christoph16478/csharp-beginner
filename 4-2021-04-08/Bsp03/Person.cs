using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    public class Person
    {

        // Eigenschaften

        public string Name { get; set; }

        //public int Energie { get; set; }
        private int _Energie;

        public int Energie
        {
            get { return _Energie; }
            set
            {
                if(value>0)
                    _Energie = value;
                else
                {
                    Console.WriteLine(" ERROR! Ich will nicht sterben :) ");
                }
            }
        }



        // Methoden
        public Person(string name) // Konstruktor
        {
            Name = name;
            Energie = 100;
        }

        // Sprechen
        // Gehen
        // Essen
        // Trinken
        // Arbeiten
        // Schlafen

        public void Essen(int menge)
        {
            // Energie = 100 + 10
            Energie += menge;
        }

        public void Gehen(int menge)
        {
            //if(Energie> menge)
            Energie -= menge;
            // Energie = 100-250
            // Energie = -150 ERROR
        }

        public void Arbeiten(int menge)
        {
            //if (Energie > menge)
            Energie -= menge;
        }

        public void Sprechen()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Ich bin " + Name);
            Console.WriteLine("und habe " + Energie + " Energie.");
        }
    }
}
