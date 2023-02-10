using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse Auto
            // Baujahr
            // Marke
            // Energie
            // Fahren
            // Tanken
            // Tankgroesse

            Auto auto1 = new Auto("BMW",150);
            auto1.Info();
            //auto1.Fahren(20);
            //auto1.Info();
            //auto1.Tanken(10);
            //auto1.Info();


            /*
            // Eigenschaften ohne Setter
            Console.WriteLine(auto1.Marke); // Auslesen zulassen aber
            auto1.Marke = "Mercedes"; // Zuweisung verhindern!
            Console.WriteLine(auto1.Marke); // Auslesen zulassen aber
            */

            /*
            Console.WriteLine("++++++++++");
            auto1.Baujahr = 2002;
            Console.WriteLine(auto1.Baujahr);

            auto1.Baujahr = -1902;
            Console.WriteLine(auto1.Baujahr);
            */

            Console.WriteLine(auto1.Baujahr);
            auto1.SetBaujahr(2021, "12345");
            Console.WriteLine(auto1.Baujahr);

        }
    }
}
