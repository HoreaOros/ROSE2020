using System;

namespace _0312
{
    class Program
    {
        static void Main(string[] args)
        {
            // fractie();
            // n_minim();
            // MinimPozitive();
            // MaxAndAp();

            Maxim2();

        }

        /// <summary>
        /// Să se scrie un program care citește un șir de n numere naturale 
        /// şi determină cele mai mari TREI numere din şir.
        /// </summary>
        private static void Maxim2()
        {
            int n, nr;
            n = int.Parse(Console.ReadLine());
            int maxim1 = int.MinValue, maxim2 = int.MinValue, maxim3 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr >= maxim1)
                {
                    maxim3 = maxim2;
                    maxim2 = maxim1;
                    maxim1 = nr;
                }
                else if (nr >= maxim2)
                {
                    maxim3 = maxim2;
                    maxim2 = nr;
                }
                else if(nr > maxim3)
                {
                    maxim3 = nr;
                }
            }
            Console.WriteLine($"{maxim1} {maxim2} {maxim3}");
        }

        /// <summary>
        /// Să se scrie un program care citește un șir de n numere naturale şi 
        /// determină valoarea maximă din șir și de câte ori apare.
        /// </summary>
        private static void MaxAndAp()
        {
            int n, nr;
            n = int.Parse(Console.ReadLine());
            int maxim = int.MinValue;
            int ap = 0;
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > maxim)
                {
                    maxim = nr;
                    ap = 1;
                }
                else if (nr == maxim)
                {
                    ap++;
                }
            }

            Console.WriteLine($"Cel mai mare numar din lista este: {maxim} si apar de {ap} ori");

        }

        private static void MinimPozitive()
        {
            int nr;
            int minim = int.MaxValue;
            do
            {
                nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                {
                    break;
                }

                if (nr > 0)
                {
                    if (nr < minim)
                    {
                        minim = nr;
                    }
                }    
            } while (true);

            if (minim == int.MaxValue)
            {
                Console.WriteLine("Lista nu contine numere pozitive");
            }
            else
            {
                Console.WriteLine($"Cel mai mic numar pozitiv este: {minim}");
            }
        }

        private static void n_minim()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string line;
            line = Console.ReadLine();

            int minim = int.MaxValue;

            

            line = line.Trim();
            line += " ";
            for (int i = 0; i < n; i++)
            {
                int pos = line.IndexOf(' ');
                string token = line.Substring(0, pos);
                
                line = line.Remove(0, pos + 1);
                line = line.TrimStart();


                int nr;
                nr = int.Parse(token);
                if (nr < minim)
                {
                    minim = nr;
                }
            }

            Console.WriteLine($"Cel mai mic numar din lista este: {minim}");
        }

        /// <summary>
        /// 
        /// </summary>
        private static void fractie()
        {
            int a, b; // numaratorul si numitorul fractiei

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            // 12 / 20 ==> 3 / 5 = 0.6 =>> fractie neperiodica
            // 3 / 9 ==> 1 / 3 =>> 0.(3) =>> fractie periodica simpla
            // 1 / 6 =>> 0.1(6) =>> fractie periodica mixta
            // 4 / 15 ==>> 0.2(6) fractie periodica mixta

            // 6 / 15 =>> 2 / 5 = 0.4


            // Aducem fractia la forma ireductibila 
            int d;
            d = cmmdc(a, b);
            d = cmmdc2(a, b);

            a = a / d;
            b = b / d;

            int c2 = 0, c5 = 0;
            int aux = b;
            while (aux % 2 == 0)
            {
                aux = aux / 2;
                c2++;
            }
            while (aux % 5 == 0)
            {
                aux = aux / 5;
                c5++;
            }
            if (aux == 1)
            {
                Console.WriteLine($"Fractia {a} / {b} este neperiodica");
            }
            else if(c2 == 0 && c5 == 0)
            {
                Console.WriteLine($"Fractia {a} / {b} este periodica simpla");
            }
            else
            {
                Console.WriteLine($"Fractia {a} / {b} este periodica mixta");
            }
        }
        /// <summary>
        /// Algoritmul lui Euclid - implementat prin impartiri
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int cmmdc2(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        /// <summary>
        /// Algoritmul lui Euclid - implementat cu diferente
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
    }
}
