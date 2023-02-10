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
            // Arrays

            int[] a = new int[5];
            a[0] = 10;
            a[1] = 11;
            a[2] = 12;
            a[3] = 13;
            a[4] = 14;
            //a[5] = 15; // Außerhalb. Immer ab 0. Max bis 4

            for(int i=0; i<a.Length; i++) // Solange i kleiner als Array-Länge ist.
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("-------------");

            //Console.WriteLine(String.Join(";",a));
            Console.WriteLine(String.Join("\n", a));

            Console.WriteLine("+++++++++++");

            int[] e = { 10, 3, 5, 7, 9 };
            Console.WriteLine(String.Join("\n", e));

            Console.WriteLine("------------");

            // Einen weiteren Wert hinzufügen.

            List<int> zahlenliste = new List<int>();
            zahlenliste.Add(5);
            Console.WriteLine(String.Join(";",zahlenliste));
            zahlenliste.Add(10);
            Console.WriteLine(String.Join(";", zahlenliste));

            // CSV
            // Max;Mustermann;1950    ---> ARRAY
            // Erika;Musterfrau;1960
            // Felix;Mustersohn;1980

            Console.WriteLine("***************");

            List<string> namenListe = new List<string>();
            namenListe.Add("Max");
            namenListe.Add("Erika");
            namenListe.Add("Felix");

            Console.WriteLine(String.Join(";",namenListe));
            namenListe.Remove("Erika");
            Console.WriteLine(String.Join(";", namenListe));
            Console.WriteLine(namenListe.Count);



        }
    }
}
