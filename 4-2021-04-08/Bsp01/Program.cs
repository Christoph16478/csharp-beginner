using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klassen
            // eine Klasse ist ein Bauplan für Objekte

            // Statische Klassen ---> ManagerKlassen
            // Nicht statische Klassen

            // Eigenschaften (Variablen)
            // ---> Felder? Variablen, die werden nicht geprüft.
            // -----> Eigenschaften: die werden geprüft
            // Methoden (Fähigkeiten)

            // Wie erstelle ich eine Klasse 
            // eine Person Klasse erstellen

            // Wie kann ich die Methode in der Klasse aufrufen?
            // zuerst ein Objekt erstellen

            Person diePerson = new Person(); // ein Objekt instanziert
            diePerson.Name = "Felix";
            diePerson.Alter = 20;
            //diePerson.SagHallo();
            diePerson.SagHallo2();
            diePerson.SagAlter();

            Person person2 = new Person();
            person2.Name = "Max";
            person2.Alter = 50;
            person2.SagHallo2();
            person2.SagAlter();


            diePerson.Infos();
            person2.Infos();

            Console.WriteLine("++++++++++++++++++++++");

            diePerson.Alter = -2;
            diePerson.Infos();

            diePerson.Alter = 3;
            diePerson.Infos();

            diePerson.Alter = 300;
            diePerson.Infos();

        }

    }
}
