using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Lebewesen leb1 = new Lebewesen();
            leb1.Name = "x12c";
            Console.WriteLine(leb1.Name);

            Person person1 = new Person();
            person1.Name = "Max";
            // person1.Sprechen();

            person1.Info();


            Hund hund1 = new Hund();
            hund1.Name = "Bello";
            // hund1.Bellen();

        }
    }
}
