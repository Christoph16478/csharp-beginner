using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp10
{
    class Auto
    {

        // !!!!! Nur zur Verständnis !!!!!
        // Was kann ein Auto haben?

        // Eigenschaften (Variablen)
        public string Farbe; // <--- das ist ein FELD (eine Variable)
        // ein Feld kann gelesen und geschrieben werden.

        //public int Alter;
        // prop TAB TAB
        public int Alter { get; set; } // Eigenschaft
        // Zugriffsüberprüfungen sind möglich


        // Fähigkeiten (Methoden)
        public void Fahren()
        {
            Console.WriteLine("Auto fährt.");
        }

    }
}
