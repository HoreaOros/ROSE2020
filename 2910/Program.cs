using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2910
{
    class Program
    {
        /// <summary>
        /// citeste doua numere de la tastatura si afiseaza suma lor
        /// cele doua numere sunt pe un singur rand separate printr-un spatiu
        /// </summary>
        static void sum00()
        {
            int a = 0, b = 0;
            string line;

            line = Console.ReadLine();
            // "12 23" => "12", "23"

            string[] numere = line.Split(' ');

            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);



            int suma;

            suma = a + b;
            Console.WriteLine(suma);
        }
        static void asii()
        {
            int a = 0, b = 0;
            string line;

            line = Console.ReadLine();
            // "12     23" => "12", "23"

            char[] seps = { ' ', '.', ',', '?' };
            string[] numere = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);

            Console.WriteLine($"{a + b} {a - b} {a * b } {a / b}");
        }
        static void uciv()
        {
            int x, y;
            int uc;
            string line;

            line = Console.ReadLine();
            // "12     23" => "12", "23"

            char[] seps = { ' ', '.', ',', '?' };
            string[] numere = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);


            uc = (x + y) % 10; // restul impartirii la 10


            // 78:10 = ?;
            // 78 / 10 => 7
            // 78 % 10 => 8

            // cele 3 instructiuni de mai jos toate fac acelasi lucru
            Console.WriteLine(uc);
            Console.WriteLine($"{uc}");
            Console.WriteLine("{0}", uc);
        }
        static void parc()
        {
            int n;
            n = int.Parse(Console.ReadLine());


            // Varianta 1.
            //int alei, arbori, crengi, cuiburi, pasari;

            //alei = n;

            //arbori = n * alei;
            //crengi = n * arbori;
            //cuiburi = n * crengi;
            //pasari = n * cuiburi;


            // Varianta 2.
            //Console.WriteLine(n * n * n * n * n);


            // Varianta 3.
            Console.WriteLine(Math.Pow(n, 5));

            Console.WriteLine();
        }
        public static void bomboane()
        {
            int B, S;
            string line;

            line = Console.ReadLine();

            char[] seps = { ' ', '.', ',', '?' };
            string[] numere = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            B = int.Parse(numere[0]);
            S = int.Parse(numere[1]);

            int C, P;

            C = S / B;
            P = (C + 1) * B - S;

            Console.WriteLine($"{C} {P}");
        }
        static void patratMagic()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //1, 2, 3, ...., n^2
            int suma;
            suma = n * (n * n + 1) / 2;

            Console.WriteLine(suma);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
