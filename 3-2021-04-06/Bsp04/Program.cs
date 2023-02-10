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
            List<string> liste1 = new List<string>();
            liste1.Add("Max");
            liste1.Add("Erika");
            liste1.Add("Felix");

            foreach (string eintrag in liste1)
            {
                Console.WriteLine(eintrag);
            }

            Console.WriteLine("------------");

            liste1.Sort();

            foreach (string eintrag in liste1)
            {
                Console.WriteLine(eintrag);
            }


        }
    }
}
