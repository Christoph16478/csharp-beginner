using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp04
{
    class Auto
    {
        // Eigenschaften

        //public int Baujahr { get; set; }
        private int _Baujahr;

        public int Baujahr
        {
            get { return _Baujahr; }
            //set { _Baujahr = value; }
        }


        //public string Marke { get; set; }
        private string _Marke;  // das ist ein FELD
                                // (Zwischenspeicher für die Eigenschaft)

        public string Marke // das ist eine Eigenschaft
        {
            get { return _Marke; } // Das ist der Verbindungspunkt
            //set { _Marke = value; }
        }




        private int _Energie;

        public int Energie
        {
            get
            {
                return _Energie;
            }
            set
            {
                if (value > 0 && value < Tankgroesse)
                    _Energie = value;
                //else Console.WriteLine("Tank ist leer");
            }
        }

        public int Tankgroesse { get; set; }




        // Methoden

        public Auto(string marke, int tankgroesse) // Konstruktor
        {
            //Marke = marke; // Zuweisung an die Eigenschaft Marke! ERROR! Kein SETTER
            _Marke = marke; // Zuweisung an die Eigenschaft Marke
            _Baujahr = 2002; // Fabrik-Einstellung
            Tankgroesse = tankgroesse;

            //Tankgroesse = 100;
            Energie = 100;
        }

        public void Fahren(int menge)
        {
            Energie -= menge;
        }

        public void Tanken(int menge)
        {
            Energie += menge;
        }

        public void Info()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Marke : " + Marke);
            Console.WriteLine("Energie: " + Energie);

        }

        // Operatoren sind für die spezielle Zugriffe zuständig.
        // Get....()
        // Set....()
        public void SetBaujahr(int baujahr, string pwd)
        {
            if(pwd == "12345")
                _Baujahr = baujahr;
        }

        // ----- Aufgabe -----
        // Klasse Kreis
        // Radius r soll angegeben werden über den Konstruktor.
        // Über die Methoden sollen Umfang() und Flaeche() berechnet werden.
        // Umfang und Flaeche sollen auch über die Eigenschaften auch
        // ausgelesen werden können. Bsp:
        //Console.WriteLine(kreis1.Umfang);
        //Console.WriteLine(kreis1.Flaeche);



    }
}
