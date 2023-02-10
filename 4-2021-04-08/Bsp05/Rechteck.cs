using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp05
{
    public class Rechteck
    {
        public double Breite { get; set; }
        public double Hoehe { get; set; }

        // ----- Eine Abgeleite Eigenschaft ------
        // private double _Flaeche; // FELD auskommentieren
        public double Flaeche
        {
            //get { return _Flaeche; }
            get { return GetFlaeche(); } 
            // Der Wert der normale weise aus dem Feld kommen soll,
            // kommt nun aus einem Operator.

            // set { _Flaeche = value; } // SET auskommentieren
        }

        

        public double Umfang
        {
            get { return GetUmfang(); }
        }



        public Rechteck(double breite, double hoehe)
        {
            Breite = breite;
            Hoehe = hoehe;
        }

        private double GetFlaeche() // Das ist ein Operator
        {
            double flaeche = 0;
            flaeche = Breite * Hoehe;
            return flaeche;
        }

        private double GetUmfang()
        {
            double umfang;
            umfang = 2 * (Breite + Hoehe);
            return umfang;
        }

    }
}
