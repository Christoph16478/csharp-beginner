using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp04
{
    class Program
    {
        static string connectionstring = @"Data Source=db-csharp.bfi.wien;Initial Catalog=db01;Persist Security Info=True;User ID=xxxxxxdd;Password=xxddXXX!DD";
        static SqlConnection con; //Deklaration
        static void Main(string[] args)
        {
            // Verbindung zum SQL Server herstellen = ConnectionString = Verbindungszeichenkette
            // Das ist ein Text, der die Zugangsdaten beinhaltet.
            // Ansicht --> Serverexplorer aktivieren
            // Data Source=db-csharp.bfi.wien;Initial Catalog=db01;Persist Security Info=True;User ID=dbuser01;Password=***********

            // string connectionstring =@"Data Source=db-csharp.bfi.wien;Initial Catalog=db01;Persist Security Info=True;User ID=dbuser01;Password=xx99TRP!01";
            // Hier ist connectionstring nur in der main Methode Anwendbar.
            // Das heißt in den weitern Methoden kann diese Information nicht ausgelesen werden.
            // Lösung: Di Variable rauf holen! Somit ist es eine globale Variable!

            // nach außen Verbidnungen aufbauen kann bedeuten, dass der Server einen Fehler gibt
            // und deshalb sollten wir Fehler abfangen können
            try
            {
                con = new SqlConnection(connectionstring); //Hier Instanziieren
                con.Open(); //Verbidnung zum Server öffnen

                Auflisten();
                // Auslesen();
                // Suche();
                // Eintragen();
                // Aktualisierung();
                // Loeschen();

                con.Close(); //Verbindung zum Server schließen
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                //throw;
            }
        }

        private static void Loeschen()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Personal WHERE Personalnummer=6", con); // SQL Statement definiert
            int anzahl = cmd.ExecuteNonQuery(); // Anzahl der betroffenen Zeilen.
            Console.WriteLine("Anzahl:" + anzahl);
        }

        private static void Aktualisierung()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Personal SET Vorname = 'Felix2' WHERE Personalnummer=5", con); // SQL Statement definiert
            int anzahl = cmd.ExecuteNonQuery(); // Anzahl der betroffenen Zeilen.
            Console.WriteLine("Anzahl:" + anzahl);
        }

        private static void Eintragen()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Personal (Anrede,Vorname,Nachname,Gebjahr) VALUES ('Herr','Franz','Super',1980)", con); // SQL Statement definiert
            int anzahl = cmd.ExecuteNonQuery(); // Anzahl der betroffenen Zeilen.
            Console.WriteLine("Anzahl:" + anzahl);
        }

        private static void Suche()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personal WHERE Vorname LIKE '%x%'", con); // SQL Statement definiert
            SqlDataReader rd = cmd.ExecuteReader(); // Liefert die Liste in das Objekt rd
            while (rd.Read())
            {
                Console.WriteLine(rd["Anrede"].ToString() + " " +
                                rd["Vorname"].ToString() + " " +
                                rd["Nachname"].ToString() + " " +
                                rd["Personalnummer"] + " " +
                                rd["GebJahr"].ToString());
            }
            rd.Close();
        }

        private static void Auslesen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personal WHERE Personalnummer = 2;", con); // SQL Statement definiert
            SqlDataReader rd = cmd.ExecuteReader(); // Liefert die Liste in das Objekt rd
            // Wir erwarten eine einzigen Eintrag. Deshalb if
            if (rd.Read()) // True falls ein noch nicht gelesener Eintrag existiert.
            {
                Console.WriteLine(rd["Anrede"].ToString() + " " +
                rd["Vorname"].ToString() + " " +
                rd["Vorname"].ToString() + " " +
                rd["Personalnummer"] + " " +
                rd["GebJahr"].ToString());
            }
            rd.Close();
        }

        private static void Auflisten()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personal;", con); // SQL Statement definiert
            SqlDataReader rd = cmd.ExecuteReader(); // Liefert die Liste in das Objekt rd

            // Mit Schleife durchlaufen weil es vermittelt ob noch weiter ungelesene Objekte eingelesen werden
            while (rd.Read())
            {
                Console.WriteLine(rd["Anrede"].ToString() + " " +
                                rd["Vorname"].ToString() + " " +
                                rd["Vorname"].ToString() + " " +
                                rd["Personalnummer"] + " " +
                                rd["GebJahr"].ToString());
            }
            rd.Close();
        }
    }
}
