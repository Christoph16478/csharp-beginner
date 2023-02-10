using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Hallo123,'.!$%";

            char zeichen1 = 'a';

            Console.WriteLine(text1);
            Console.WriteLine(zeichen1);

            Console.WriteLine( (int)zeichen1 );
            // Den ASCII Wert vom Zeichen 'a'

            // a -----> 97
            //int zahl1 = (int)zeichen1;
            int zahl1 = zeichen1;
            Console.WriteLine(zahl1);

            int zahl2 = 64;
            char zeichen2 = (char)zahl2;
            Console.WriteLine(zeichen2);
            // 64. Zeichen aus der ASCII Tabelle

            Console.WriteLine("---------------");

            for (int i = 0; i < 255; i++)
            {
                //Console.WriteLine( i + " : " + (char)i );
                Console.Write(i + ":" + (char)i + "\t");
            }


        }
    }
}
