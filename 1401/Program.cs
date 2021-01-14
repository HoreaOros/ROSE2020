using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1401
{
    class Program
    {
        static void Main(string[] args)
        {
            // EasyPow();
            // CifBin();
            // CifBin2();
            // CifreBinare();
            // BazaMinima();
            // transfB();
            // SumaPuteri2();
            // Putere1();
        }

        private static void Putere1()
        {
            ulong b, n, p;
            ulong M;

            b = ulong.Parse(Console.ReadLine());
            n = ulong.Parse(Console.ReadLine());
            p = ulong.Parse(Console.ReadLine());

            M = (ulong)Math.Pow(10, p);


            //Console.WriteLine(b^n (mod M));

            Console.WriteLine(MyModPower(b, n, M));
        }

        private static ulong MyModPower(ulong b, ulong n, ulong M)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n % 2 == 1)
            {
                return (b * MyModPower(b, n - 1, M)) % M;
            }
            else
            {
                ulong ret = MyModPower(b, n / 2, M);
                return (ret * ret) % M;
            }
        }

        /// <summary>
        /// Se dă un număr natural n. Descompuneți numărul n ca sumă de puteri ale lui 2.
        /// </summary>
        private static void SumaPuteri2()
        {
            // 43(10) = 101011(2)

            int n, cifra, putere2 = 1;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                cifra = n % 2;
                n /= 2;
                if (cifra == 1)
                {
                    Console.Write($"{putere2} ");
                }
                putere2 *= 2;
            }
        }

        private static void transfB()
        {
            int baza, n;
            string line1, line2;
            char[] seps = {' ', '\t'};
            line1 = Console.ReadLine();
            line2 = Console.ReadLine();
            
            string[] tokens;
            
            tokens = line1.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            baza = int.Parse(tokens[0]);
            n = int.Parse(tokens[1]);

            tokens = line2.Split(seps,StringSplitOptions.RemoveEmptyEntries);

            int[] cifre = new int[tokens.Length];

            for (int i = 0; i < cifre.Length; i++)
            {
                cifre[i] = int.Parse(tokens[i]);
            }


            //102241 = 1*5^5+0*5^4+2*5^3+2*5^2+4*5^1+1*5^0

            int result = 0;
            foreach (var item in cifre)
            {
                result = result * baza + item;
            }
            Console.WriteLine($"Numarul in baza 10 este: {result}");
        }

        /// <summary>
        /// Se dau n numere naturale. Determinați cea mai mică bază de numerație b în care ar putea fi considerate aceste numere.
        /// </summary>
        private static void BazaMinima()
        {
            int n, nr, cifra, cifraMaxima = 0;

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                while (nr > 0)
                {
                    cifra = nr % 10;
                    nr /= 10;
                    if (cifra > cifraMaxima)
                    {
                        cifraMaxima = cifra;
                    }
                }
            }
            Console.WriteLine($"Cea mai mica baza in care pot fi considerate numerele este: {cifraMaxima + 1}");
        }

        private static void CifreBinare()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (Cifra1B2(a) > Cifra1B2(b))
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }

        private static int Cifra1B2(int n)
        {
            int U = 0, cifra;
            while (n > 0)
            {
                cifra = n % 2;
                n = n / 2;

                if (cifra == 1)
                    U++;
            }
            return U;
        }

        private static void CifBin2()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int Z = 0, U = 0;

            while (n != 0)
            {
                if ((n & 1) == 1)
                    U++;
                else
                    Z++;
                n = n >> 1;
            }
            Console.WriteLine($"Zero: {Z}, Unu: {U}");
        }

        /// <summary>
        /// Se citește un număr natural n. Să se determine câte cifre 0 și câte cifre 1 are reprezentarea în baza 2 a acestui număr.
        /// </summary>
        private static void CifBin()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int Z = 0, U = 0;
            int cifra;
            while (n > 0)
            {
                cifra = n % 2;
                n = n / 2;

                if (cifra == 0)
                    Z++;
                else
                    U++;
            }

            Console.WriteLine($"Zero: {Z}, Unu: {U}");
        }

        /// <summary>
        /// Se afiseaza 2^n in baza 2
        /// </summary>
        private static void EasyPow()
        {
            // 2^3 = 8 => 1000 
            int n;
            n = int.Parse(Console.ReadLine());
            Console.Write(1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(0);
            }
            Console.WriteLine();
        }
    }
}
