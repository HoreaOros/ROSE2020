using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1911
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaxCadou();

            PerechiPare();
        }

        /// <summary>
        /// Se dă un interval [l,r]. 
        /// Aflaţi câte perechi de numere pare se pot forma 
        /// alegând două numere din interval.
        /// </summary>
        /// <example>
        /// pentru [5, 10] rezultatul este 9
        /// (6,8),(6,10),(8,10),(8,6),(10,6),(10,8),(6,6),(8,8),(10,10)
        /// </example>
        private static void PerechiPare()
        {
            int st, dr;
            st = int.Parse(Console.ReadLine());
            dr = int.Parse(Console.ReadLine());
            int contor = 0;
            int i, j;
            for (i = st; i <= dr; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = st; j <= dr; j++)
                    {
                        if (j % 2 == 0)
                        {
                            contor++;
                            Console.WriteLine($"({i},{j}) ");
                        } // if
                    } // for
                } // if
            } // for
        } 

        private static void MaxCadou()
        {
            long n; // long se stocheaza pe 64 biti.
            StreamReader sr = new StreamReader("maxcadou.in");
            string line = sr.ReadLine();
            sr.Close();

            n = long.Parse(line);

            // ex. n = 17279145
            // index    0|1|2|3|4|5|6|7|8|9
            // valoarea 0 2 1 0 1 1 0 2 0 1
            int[] v = new int[10];
            int cifra; 
            while (n > 0)
            {
                cifra = (int)(n % 10);
                v[cifra]++;
                n /= 10;
            }
            long result = 0;
            for (int i = v.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < v[i]; j++)
                {
                    result = result * 10 + i;
                }
            }

            StreamWriter sw = new StreamWriter("maxcadou.out");
            sw.WriteLine(result);
            sw.Close();
        }
    }
}
