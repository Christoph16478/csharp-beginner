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
            try
            {
                // Hund (Klassenname)
                // Name
                Hund hund1 = new Hund("Felix");
                Console.WriteLine(hund1.ToString());

                //Hund hund2 = new Hund("");
                ////hund2.Name = "mario";
                //Console.WriteLine(hund2.ToString());

                //Hund hund2 = new Hund("");
                //hund2.Name = "mario";
                //Console.WriteLine(hund2.ToString());

                // hund3.Energie = -100;
                //hund2.Name = "mario";
                // Console.WriteLine(hund3.ToString());

                //throw; // Ohne throw stürzt das Programm nicht ab!

                //Hund hund3 = new Hund("Adler");
                //hund3.Energie = -100;
                ////hund2.Name = "mario";
                //Console.WriteLine(hund3.ToString());

                Hund hund3 = new Hund("Adler12");
                hund3.Bellen(); Console.WriteLine(hund3);
                hund3.Laufen(20); Console.WriteLine(hund3);
                hund3.Fressen(50); Console.WriteLine(hund3);

                List<Hund> HundeListe = new List<Hund>();
                HundeListe.Add(hund1);
                HundeListe.Add(hund3);

                // Die Liste anweden
                // 1. lle Hunde solen 50 fressen
                foreach (var hund in HundeListe)
                {
                    hund.Fressen(50); Console.WriteLine(hund);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                //throw;
            }
        }
    }
}
