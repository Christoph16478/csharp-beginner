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
            // Strg + F5 : Starten
            // F5 : Starten in Debug modus od. PLAY Zeichen
            for (int counter = 0, b = 10; counter<=10 && b>5; counter +=2)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
