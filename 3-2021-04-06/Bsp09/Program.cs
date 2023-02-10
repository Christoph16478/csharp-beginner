using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp09
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array1 = { "Max", "Erika", "Felix" };

            List<string> liste1 = array1.ToList();

            foreach (var eintrag in liste1)
            {
                Console.WriteLine(eintrag);
            }

            Console.WriteLine("---------");

            string[] array2 = liste1.ToArray();
            foreach (var eintrag in array2)
            {
                Console.WriteLine(eintrag);
            }

            Methode1(array2);
            Methode2(liste1);

            string[] array3 = Methode3();

            List<string> liste2 = Methode4();


        }

        private static List<string> Methode4()
        {
            string[] namen = { "Max", "Erika" };
            return namen.ToList();
        }

        private static string[] Methode3()
        {
            string[] namen = { "Max", "Erika" };
            return namen;
        }



        private static void Methode2(List<string> liste1)
        {
            foreach (var eintrag in liste1)
            {
                Console.WriteLine(eintrag);
            }
        }

        private static void Methode1(string[] array2)
        {
            foreach (var eintrag in array2)
            {
                Console.WriteLine(eintrag);
            }
        }
    }
}
