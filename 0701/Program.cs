using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0701
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci1(5);
            //fibonacci2(1, 1, 5);
            Console.WriteLine($"Al 5-lea numar din sirul Fibonacci este: {fibonacci3(5)}"); 

            //int n = 100;
            //fibonacci4(n);

            // int n = 40, a = -1, b = 2;
            // fibonacci5(n, a, b);

            //int n = 50;
            //fibonacci6(n);

            //egale();

        }

        private static void egale()
        {
            StreamReader sr = new StreamReader("egale.in");
            int T, a, b, x;
            T = int.Parse(sr.ReadLine());
            if (T == 1)
            {
                string line = sr.ReadLine();
                char[] seps = { ' ' };
                string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                a = int.Parse(tokens[0]);
                b = int.Parse(tokens[1]);
                egale1(a, b);
            }
            else if(T == 2)
            {
                x = int.Parse(sr.ReadLine());
                egale2(x);
            }
            sr.Close();
        }

        /// <summary>
        /// Genereaza toate numerele cu maxim x cifre care au toate cifrele egale
        /// </summary>
        /// <param name="x"></param>
        private static void egale2(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void egale1(int a, int b)
        {
            StreamWriter sw = new StreamWriter("egale.out");
            for (int nr = a; nr <= b; nr++)
            {
                if (CifreEgale(nr))
                {
                    sw.Write($"{nr} ");
                }
            }
            sw.Close();
        }

        private static bool CifreEgale(int nr)
        {
            int uc;

            uc = nr % 10;

            while (nr > 0)
            {
                if (nr % 10 != uc)
                {
                    return false;
                }
                nr /= 10;
            }

            return true;
        }

        private static void fibonacci6(int n)
        {
            if (n < 1)
            {
                return;
            }
            int fn;
            while (n > 0)
            {
                fn = MaxFib(n);
                Console.WriteLine($"{fn} ");
                n -= fn;
            }
        }

        /// <summary>
        /// Metoda intoarce cel mai mare numar Fibonacci mai mic sau egal decat n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int MaxFib(int n)
        {
            int f1 = 1, f2 = 1, f3;
            if (n == 1)
            {
                return 1;
            }

            
            while (f1 + f2 <= n)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f2;
        }

        /// <summary>
        /// Genereaza primii n termeni din sirul Fibonacci generalizat
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void fibonacci5(int n, int a, int b)
        {
            int f1 = a, f2 = b, f3;

            if (Math.Abs(a) <= n)
            {
                Console.WriteLine(a);
            }
            else
                return;
            if (Math.Abs(b) <= n)
            {
                Console.WriteLine(b);
            }
            else
                return;

            do
            {
                f3 = f1 + f2;
                if (Math.Abs(f3) <= n)
                {
                    Console.WriteLine(f3);
                    f1 = f2;
                    f2 = f3;
                }
                else
                    break;
            } while (true);
        }

        /// <summary>
        /// Afisez termenii sirului Fibonacci mai mici sau egali decat n
        /// </summary>
        /// <param name="n"></param>
        private static void fibonacci4(int n)
        {
            int f1 = 1, f2 = 1, f3;
            if (n < 1)
            {
                return;
            }



            Console.WriteLine(1);
            Console.WriteLine(1);
            if (n == 1)
            {
                return;
            }

            do
            {
                f3 = f1 + f2;
                if (f3 <= n)
                {
                    Console.WriteLine($"{f3}");
                    f1 = f2;
                    f2 = f3;
                }
                else
                    break;
            } while (true);
        }

        /// <summary>
        /// Functia calculeaza al n-lea numar din sirul lui Fibonacci
        /// </summary>
        /// <param name="v"></param>
        private static int fibonacci3(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return fibonacci3(n - 1) + fibonacci3(n - 2);
            }
                
        }

        /// <summary>
        /// Afisam primii n termeni ai sirului lui Fibonacci recursiv
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a">primul termen din sirul Fibonacci</param>
        /// <param name="b">al doilea termen din sirul Fibonacci</param>
        private static void fibonacci2(int a, int b, int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(a);
                fibonacci2(b, a + b, n - 1);
            }
        }

        /// <summary>
        /// Afiseaza primii n termeni din sirul lui Fibonacci
        /// </summary>
        /// <param name="n"></param>
        private static void fibonacci1(int n)
        {
            int f1 = 1, f2 = 1, f3;

            if (n < 1)
            {
                return;
            }
            if (n == 1)
            {
                Console.WriteLine($"{f1}");
                return;
            }

            Console.WriteLine($"{f1}");
            Console.WriteLine($"{f2}");

            n = n - 2;
            // 1 1 2 3 5 8 13
            while (n > 0)
            {
                f3 = f1 + f2;
                Console.WriteLine($"{f3}");
                n--;

                f1 = f2;
                f2 = f3;
            }
        }
    }
}
