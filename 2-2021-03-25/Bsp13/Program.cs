using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine(a);

            int[] b = new int[5]; // Array
            // 0-4 : 0. 1. 2. 3. 4.
            b[0] = 20;
            b[1] = 35;
            Console.WriteLine(b[0]);

            b[4] = 45;
            Console.WriteLine(b[4]);
            Console.WriteLine(b[3]); // Defaultwert 0

            // b[5] = 70; <--- ERROR! MAX 4 !!

            Console.WriteLine("------");

            for(int i=0; i<5; i++)
            {
                // Console.WriteLine( i + " : " + b[i]);
                Console.WriteLine($" {i} : {b[i]} ");
            }

            Console.WriteLine("--------------");

            // Übung
            int[] c = new int[8];
            c[1] = 5;
            c[2] = 15;
            c[3] = 34;
            c[4] = 8;

            a = c[1]; // a=? 5
            a = c[3]; // a=? 34
            a = c[2 + 1]; // a=?  34
            int d = 4;
            a = c[d - 2]; // a=?  

            Console.WriteLine(a);

            Console.WriteLine("++++++++++++++++++++++");

            int[] e = { 1, 3, 5, 7, 9 };

            a = e[0]; // a=?  1
            a = e[3]; // a=?  7
            a = e[2]; // a=?  5
            // a = e[6]; // a=?  ERROR

            Console.WriteLine(a);

            Console.WriteLine("~~~~~~~~~~~~~~~~");

            for(int i=1; i<=5; i++)
            {
                Console.WriteLine(e[i-1]);
            }

            Console.WriteLine("=================");

            string text1 = "Es ist wunderschön heute";
            Console.WriteLine(text1[5]);



        }
    }
}
