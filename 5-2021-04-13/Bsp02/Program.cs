using HundeBib;
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
            Hund hund1 = new Hund("Felix");
            Console.WriteLine(hund1);
            hund1.SagHallo("Felix"); // Diese Methode wird gewünscht!
            hund1.SagHallo();
        }
    }
}
