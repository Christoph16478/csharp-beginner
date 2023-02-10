using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp07
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            name = SagHallo();

            Console.WriteLine("Deine Eingabe: " + name);

        }

        static string SagHallo()
        {
            Console.Write("Wie heißt du: ");
            return Console.ReadLine();
        }


    }
}
