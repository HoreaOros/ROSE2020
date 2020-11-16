using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1211
{
    class Program
    {
        static void Main(string[] args)
        {
            // AfisarePuteri();
            // PatratPerfect();
            // Piramida();
            //NumerePiramidale();
            //Piramida1();
            //Patrat();

            Triunghi();
        }

        private static void Triunghi()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // afisam n - i spatii

                //for (int j = 0; j < n - i; j++)
                //{
                //    Console.Write(" ");
                //}

                string pad = new string(' ', n - i);
                Console.Write(pad);

                // afisam *
                Console.Write('*');
                

                if (i == 1)
                {
                    // prima linie se trateaza diferit
                    Console.WriteLine();
                    continue;
                }
                else if(i == n)
                {
                    // ultima linie se tratateaza diferit
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write(" *");
                    }
                }
                else
                {
                    // afisam spatii 
                    // 2 -> 1
                    // 3 -> 3
                    // 4 -> 5
                    // 5 -> 7
                    // 6 -> 9
                    // afisam * 
                    
                    // 2n+1 = nr coloane
                    // o linie e formata din:
                    // spatii (n - i)
                    // *
                    // spatii din mijloc (sdm)
                    // *
                    // spatii (n - i)
                    int sdm;
                    sdm = (2 * n - 1) - 2 - 2 * (n - i);
                    pad = new string(' ', sdm);

                    Console.Write(pad);
                    Console.Write("*");
                }


                 
                

                Console.WriteLine();
            }


        }

        private static void Patrat()
        {
            int n;
            char c, d;
            string line;

            line = Console.ReadLine();
            char[] seps = {' ', '\t'}; // \t este secventa escape corespunzatoare caracterului TAB
            string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(tokens[0]);
            c = tokens[1][0];
            d = tokens[2][0];

            //Console.WriteLine($"{n},{c},{d}");
            for (int i = 1; i <= n; i++)
            {
                //afisez linia i
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write(c);
                    }
                    else if (j == 1 || j == n)
                    {
                        Console.Write(c);
                    }
                    else
                        Console.Write(d);
                }
                //trec la linia urmatoarea
                Console.WriteLine();
            }
        }

        private static void Piramida1()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            char ch;
            ch = (char)Console.Read();

            for (int i = 1; i <= n; i++)
            {
                // afisez linia i
                for (int j = 0; j < i; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }

        private static void NumerePiramidale()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int pp;
            //1 -> 1
            //4 -> 5
            //9 -> 14
            //16 -> 30
            //25 -> 55
            // 1*1+2*2+3*3

            // suma patratelor primelor n numere naturale
            // S = n*(n+1)*(2n+1)/6
            int np = 0;
            for (int i = 1; i <= n; i++)
            {
                pp = i * i;
                np  = np + pp;
                Console.WriteLine($"{np} ");
            }
        }

        private static void Piramida()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // afisam o linie (linia i)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                // trec la linia urmatoare
                Console.WriteLine();
            }
        }

        private static void PatratPerfect()
        {
            int n, nr;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (PP2(nr))
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NU");
            }
        }

        private static bool PP(int nr)
        {
            // 25 ==> 1, 5, 25 (3)
            // 20 ==> 1, 2, 4, 5, 10, 20 (6)
            // 16 ==> 1, 2, 4, 8, 16 (5)
            // un numar care este patrat perfect are un numar impar de divizori
            // un numar care nu este patrat perfect are un numar par de divizori
            int contor = 0;
            for (int d = 1; d <= nr; d++)
            {
                if (nr % d == 0)
                    contor++;
            }

            if (contor % 2 == 1)
                return true;
            else
                return false;
        }
        private static bool PP2(int nr)
        {
            // 25 ==> 1, 5, 25 (3)
            // 20 ==> 1, 2, 4, 5, 10, 20 (6)
            // 16 ==> 1, 2, 4, 8, 16 (5)
            // un numar care este patrat perfect are un numar impar de divizori
            // un numar care nu este patrat perfect are un numar par de divizori
            int contor = 2; // 1 si nr sunt divizori

            int aux = nr;
            int d = 2;
            while (d * d <= aux)
            {
                if (aux % d == 0)
                {
                    contor++;
                    if (d != aux / d)
                    {
                        contor++;
                    }
                }
                d++;
            }

            if (contor % 2 == 1)
                return true;
            else
                return false;
        }
        private static void AfisarePuteri()
        {
            int n, p;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            int v = 1;


            do
            {
                Console.Write($"{v} ");
                v = v * n; 
            } while (v <= p);


            Console.WriteLine();
        }
    }
}
