using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeBib
{
    public class Hund
    {
        // Hund (Klassenname)
        // Name
        // Fressen
        // Laufen
        // Bellen

        // Eigenschaften
        private string _Name;

        // name soll and er Geburt vergeben wreden und darf nicht leer sein!
        // Darf im Nachhineinnicht geändert werden ausnahme
        public string Name
        {
            get
            {
                return _Name;
            }
            private set
            {
                if (value != "")
                    _Name = value;
                else
                    throw new Exception("ERROR! name darf nicht leer sein!");   // ArgumentException auswählen, wenn es ein argument bleiben soll
            }
        }



        // Energie (darf nicht <= 0 sein; Set muss weg, weil es von außen nicht gesetzt werden darf.)
        // An der geburt soll er 100 bekommen.
        private int _Energie;

        public int Energie
        {
            get { return _Energie; }
            set
            {
                if (value >= 0)
                    _Energie = value;
                else
                    throw new Exception("ERROR! name darf nicht leer sein!");
            } // Setter wird nur intern angewendet und nicht extern. "private" bedeutet die Variable ist von außen nicht zugänglich
        }

        //ctor TAB TAB
        public Hund(string name)
        {
            Name = name;
            Energie = 100;
        }
        // Fressen
        public void Fressen(int menge)
        {
            Energie += menge;
        }

        // Laufen
        public void Laufen(int menge)
        {
            _Energie -= menge;
        }

        // Bellen
        public void Bellen()
        {
            Console.WriteLine("WuffWuff");
        }
        public override string ToString()
        {
            return $"{Name};{Energie}";
        }

        // Methodenüberladung soll hier möglich sein!
        public void SagHallo()
        {
            Console.WriteLine("Hallo!");
        }

        // SagHallo
        public void SagHallo(string name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}
