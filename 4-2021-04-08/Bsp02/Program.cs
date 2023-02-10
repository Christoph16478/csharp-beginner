using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Felix");
            person1.Info();

            // Verhindern dass ein objekt ohne Name instanziert wird. 
            // Konstruktor ist die Methode, die gleich beim Erstellen
            // eines Objektes ausgeführt wird.

            Person person2 = new Person(""); // Was machen wir?
            person2.Info();


        }
    }
}
