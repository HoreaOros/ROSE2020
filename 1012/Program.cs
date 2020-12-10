using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            // gen_nr_patru_cifre();
            // cmmk();
            // sumcifnrcif();

            cifmaximp();
        }

        private static void cifmaximp()
        {
            int n;

            n = int.Parse(Console.ReadLine());
            int nr, contor = 0; 
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());

                if (CifraMaxima(nr) % 2 == 1)
                {
                    contor++;
                }
            }
            Console.WriteLine($"{contor} numere au cifra maxima un numar impar");
        }

        /// <summary>
        /// Determina cifra maxima a parametrului
        /// </summary>
        /// <param name="nr">Un numar intreg</param>
        /// <returns>Cifra maxima</returns>
        private static int CifraMaxima(int nr)
        {
            int cifraMaxima = 0;
            int c;
            while (nr > 0)
            {
                c = nr % 10;
                nr /= 10;

                if (c > cifraMaxima)
                {
                    cifraMaxima = c;
                }
            }

            return cifraMaxima;
        }

        /// <summary>
        /// Se dă un număr natural n. 
        /// Determinaţi câte cifre are suma cifrelor sale.
        /// </summary>
        private static void sumcifnrcif()
        {
            ulong n;
            n = ulong.Parse(Console.ReadLine());

            int suma_cifre = SumaCifre(n);
            int nr_cifre = NumarCifre(suma_cifre);
            Console.WriteLine($"Suma cifrelor numarului {n} este {suma_cifre}");
            Console.WriteLine($"Numarul de cifre al sumei cifrelor numarului {n} este {nr_cifre}");
        }

        /// <summary>
        /// Determina numarul de cifre al parametrului
        /// </summary>
        /// <param name="n">numar intreg</param>
        /// <returns>Numarul de cifre al parametrului</returns>
        private static int NumarCifre(int n)
        {
            int contor = 0;
            while (n > 0)
            {
                n /= 10;
                contor++;
            }
            return contor;
        }

        private static int SumaCifre(ulong n)
        {
            int suma = 0;

            while (n > 0)
            {
                suma += (int)(n % 10);
                n /= 10;
            }

            return suma;
        }

        private static void cmmk()
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (k < 0 || k > 9)
            {
                Console.WriteLine("A doua valoarea trebuie sa fie o cifra zecimala.");
                return;
            }
            int ultima_cifra;
            bool ok = true;

            while (n > 0)
            {
                ultima_cifra = n % 10;
                n = n / 10;
                if (ultima_cifra > k)
                {
                    ok = false;
                }
            }

            if (ok == true)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
        }

        /// <summary>
        /// Dându-se cifrele c1 și c2, să se afișeze toate numerele de patru cifre care îndeplinesc următoarele condiții:
        ///Cifra miilor este mai mare sau egală cu c1
        ///Cifra zecilor este mai mică sau egală cu c2
        ///Cifrele sutelor și unităților sunt egale și pare
        /// </summary>
        /// <example>
        /// pentru 8 1
        ///8000
        ///8010
        ///8202
        ///8212
        ///8404
        ///8414
        ///8606
        ///8616
        ///8808
        ///8818
        ///9000
        ///9010
        ///9202
        ///9212
        ///9404
        ///9414
        ///9606
        ///9616
        ///9808
        ///9818
        /// </example>
        private static void gen_nr_patru_cifre()
        {
            int c1 = 0, c2 = 0;


            try
            {
                c1 = int.Parse(Console.ReadLine());
                c2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            if (c1 < 0 || c1 > 9 || c2 < 0 || c2 > 9)
            {
                Console.WriteLine("Nu s-au introdus doua cifre");
                return;
            }

            int m, s, z, u, nr;

            for (m = c1; m <= 9; m++)
            {
                for (s = 0; s <= 8; s = s + 2)
                {
                    for (z = 0; z <= c2; z++)
                    {
                        u = s;
                        nr = m * 1000 + s * 100 + z * 10 + u;
                        Console.WriteLine(nr);
                    }
                }
            }

        }
    }
}
