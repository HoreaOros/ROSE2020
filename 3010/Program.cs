using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3010
{
    class Program
    {
        static void RGB()
        {
            string line;

            line = Console.ReadLine();
            string[] tokens;


            char[] seps = { ' ' };
            tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            byte R, G, B;
            R = byte.Parse(tokens[0]);
            G = byte.Parse(tokens[1]);
            B = byte.Parse(tokens[2]);

            Console.WriteLine($"{255 - R} {255 - G} {255 - B}");

        }
        static void Main(string[] args)
        {
            // RGB();

            // albina();

            // cifre();

            // a16();

            //radacinaPatrata();

            //cifraPI();

            // numarMultipli();

            elimCifra();

        }

        private static void elimCifra()
        {
            int n = int.Parse(Console.ReadLine());

            int s, z, u;
            s = n / 100 % 10;
            u = n % 10;
            //z = n / 10 % 10; // de cifra zecilor nu avem nevoie

            n = s * 10 + u;
            Console.WriteLine(n);


            //Console.WriteLine(n / 100 % 10 * 10 + n % 10);
        }

        private static void numarMultipli()
        {
            string line;

            line = Console.ReadLine();
            string[] tokens;


            char[] seps = { ' ' };
            tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);


            int a, b;
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            int m = 10;

           
            //(0, 1, 2,...., a - 1, a, a + 1, ....., b]
            // b / 10
            // (0, 1, 2,...., a - 1], a, a + 1, ....., b
            // (a-1)/10
            //0, 1, 2,...., a - 1, [a, a + 1, ....., b]
            // b/10 - (a-1)/10

            Console.WriteLine(b / m - (a - 1) / m);


        }

        private static void cifraPI()
        {
            //double d = double.Parse(Console.ReadLine());

            double d = 3.123;
            double pi = Math.Floor(d); // partea intreaga
            double pf = d - pi;

            double epsilon = 0.000000001;
            if (Math.Abs(pf - 0.123) < epsilon)
            {
                Console.WriteLine("BINGO");
            }
            else
            {
                Console.WriteLine("Partea fractionara nu este 0.123");
            }

            Console.WriteLine($"{pi} - {pf}");




            Console.WriteLine($"Ultima cifra a partii intregi: {(int)pi % 10}");


            Console.WriteLine($"Prima cifra dupa virgula: {Math.Floor(pf * 10)}");
        }

        private static void radacinaPatrata()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(n));

            
        }

        static void a16()
        {
            int a = int.Parse(Console.ReadLine());
            // Console.WriteLine(Math.Pow(a, 16));

            

            int a2 = a * a;
            int a4 = a2 * a2;
            int a8 = a4 * a4;
            Console.WriteLine(a8 * a8);

            //a^n = 1 daca n = 0
            //      a * a^(n-1) daca n este impar
            //      (a^(n/2))^2 daa n este par.

        }

        /// <summary>
        /// Afisam suma ultimelor doua cifre a unui numar citit de la tastatura
        /// </summary>
        static void cifre()
        {
            int n = int.Parse(Console.ReadLine());

            int u, z;

            n = Math.Abs(n);

            u = n % 10;
            z = n / 10 % 10;
            Console.WriteLine(u + z);
        }

        static void albina()
        {
            // 1
            // 6
            // 12
            // 18
            // total: 37
            // 1 + 6 + 12 + 18
            // 1 + 6(1+2+3)
            //1+6(1+2+...+n-1)

            int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(1 + 6 * (n-1)* n / 2);
            Console.WriteLine(1 + 3 * (n - 1) * n);
        }
    }
}
