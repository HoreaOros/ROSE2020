using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _511
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prod2Cons();
            // CifreComune();
            // CifreZecimale();
            // CatePare();
            // AfisareNumere();
            //AfisareNumere1();
            //AfisareNumere2();


            //AfisareNumerePare();
            //AfisareNumereParev2();

            //p10();

            PatratPerfect();
        }

        private static void PatratPerfect()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int p = 1;
            while (p * p < n)
            {
                p++;
            }

            if (p * p == n)
            {
                Console.WriteLine("Este patrat perfect");
            }
            else
            {
                Console.WriteLine("Nu este patrat perfect");
            }
        }

        private static void p10()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            Console.Write(1);
            if (n == 0)
            {
                return;
            }
            else if(n == 1)
            {
                Console.WriteLine("0");
                return;
            }
            else if(n == 2)
            {
                Console.WriteLine("00");
                return;
            }


            switch (n % 3)
            {
                case 0:
                    Console.Write(".");
                    break;
                case 1:
                    Console.Write("0.");
                    n--;
                    break;
                case 2:
                    Console.Write("00.");
                    n = n - 2;
                    break;

                default:
                    break;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(0);
                if (i % 3 == 0 && i < n)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        private static void AfisareNumereParev2()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{2 * i} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Se dă un număr natural n. 
        /// Afișați în ordine crescătoare primele n numere naturale pare nenule.
        /// </summary>
        private static void AfisareNumerePare()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int contor = 0;
            int nr = 2;

            while (contor < n)
            {
                Console.Write($"{nr} ");
                contor++;
                nr = nr + 2; // nr += 2;
            }
            Console.WriteLine();
        }

        private static void AfisareNumere2()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            AfisareNumere(n);
            Console.WriteLine();
            AfisareNumere1(n);
            Console.WriteLine();

        }

        private static void AfisareNumere1(int n)
        {
            for (int i = n; i >= 1; i = i - 1) // i = i - 1 <==> i--;
            {
                Console.Write($"{i} ");
            }
        }

        private static void AfisareNumere(int n)
        {
            //for(initializare; conditie; reinitializare)
            //{
            //  instructiune1;
            //  instructiune2;
            // .....
            //}
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
        }

        /// <summary>
        /// Se citesc numere de la tastatură până la apariția lui zero. Să se determine câte dintre ele erau pare.
        /// </summary>
        private static void CatePare()
        {
            int n;
            int contorPare = 0; // numara cate numere pare am introdus

            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0 && n % 2 == 0)
                {
                    contorPare++;
                }
            } while (n != 0);

            if (contorPare == 0)
            {
                Console.WriteLine("Nu exista");
            }
            else
            {
                Console.WriteLine($"Numarul de numere pare din secventa este {contorPare}");
            }
        }

        /// <summary>
        /// Se consideră șirul de cifre zecimale obținut prin scrierea consecutivă a numerelor naturale de la 10 la 99: 101112131415...9596979899.
        /// Pentru un k dat, să se afișeze cifra ce apare în acest șir pe poziția k.
        /// </summary>
        private static void CifreZecimale()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            // 10111213141516171819
            // 20212223242526272829
            // 30313233343536373839
            // 40414243444546474849
            // ....
            // 90919293949596979899

            // daca k este par
            // 012345678901234567890123456789... 90 de cifre

            // daca k este impar
            // 11111111112222222222....9999999999 .. 90 cifre
        }

        /// <summary>
        /// Se citesc două numere naturale n m cu exact două cifre fiecare. 
        /// Să se decidă dacă cele două numere au cifre comune.
        /// </summary>
        /// <example>pentru 27 si 62 se afiseaza DA</example>
        private static void CifreComune()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int m;
            m = int.Parse(Console.ReadLine());


            int nu, nz, mu, mz;

            nu = n % 10;
            nz = n / 10 % 10;

            mu = m % 10;
            mz = m / 10 % 10;

            if (nu == mu || nu == mz || nz == mu || nz == mz)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }

        }


        private static void Prod2Cons()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a;
            // n = a(a+1);
            // a^2 + a - n = 0;
            // a = (-1 + sqrt(1 + 4n)) / 2;

            // verific daca 1+4n este patrat perfect
            // n = 12 ==> 1+4n = 49 = 7*7
            // n = 30 ==> 1+4n = 121 = 11*11
            // n = 90 ==> 1+4n = 361 = 19*19
            // daca 1+4n este patrat perfect verific daca sqrt(1+4n) este nr impar

            int r = (int)Math.Sqrt(1 + 4 * n);
            if ((r * r == 1 + 4 * n) && ((1 + 4 * n) % 2 == 1))
            {
                    // afisez solutia
                    a = (-1 + (int)Math.Sqrt(1 + 4 * n)) / 2;
                    Console.WriteLine($"{a} {a + 1}");
            }
            else
            {
                Console.WriteLine("NU EXISTA");
            }
        }
    }
}
