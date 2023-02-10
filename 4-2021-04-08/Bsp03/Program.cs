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
            Person person1 = new Person("Max");
            person1.Sprechen();
            person1.Essen(50);
            person1.Sprechen();
            person1.Gehen(25);
            person1.Arbeiten(8);
            person1.Sprechen();

            person1.Gehen(250);
            person1.Sprechen();


        }
    }
}
