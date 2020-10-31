using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3110
{
    class Program
    {
        static void AfCar()
        {
            int c = Console.Read();

            Console.WriteLine(c);
            Console.WriteLine((char)c);

            Console.WriteLine((char)(c + 10));

            char ch = 'h';
            Console.WriteLine((int)ch);
            Console.WriteLine(Char.ToUpper(ch));

            char chUp = (char)((int)'A' + ((int)ch - (int)'a'));
            Console.WriteLine(chUp);

           
            
        }
        static void Main(string[] args)
        {
            //AfCar();

            // paritate();

            //maxim();

            //sticle();

            //interval();

            // minim3();

            //suma3MaxDin5();

            // luna();

            // CifEgale();

            urm00();
        }

        private static void urm00()
        {
            string line;
            line = Console.ReadLine();

            int n = int.Parse(line);

            // 3476 => 3500
            // 3400 => 3400

            int m = n;
            m = m / 100;
            if (n % 100 > 0)
            {
                m++;
            }
            n = m * 100;
            Console.WriteLine(n);
        }

        private static void CifEgale()
        {
            string line;
            line = Console.ReadLine();

            int n = int.Parse(line);

            int u, z, s;

            u = n % 10;
            z = n / 10 % 10;
            s = n / 100 % 10;

            if (u == z && z == s)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }

        }

        private static void luna()
        {
            string line;
            line = Console.ReadLine();

            int n = int.Parse(line);

            /*
            if (n == 1)
            {
                Console.WriteLine("Ianuarie");
            }
            else if (n == 2)
            {
                Console.WriteLine("Februarie");
            }
            else if (n == 2)
            {
                Console.WriteLine("Martie");
            }
            //...



            switch (n)
            {
                case 1:
                    Console.WriteLine("Ianuarie");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Martie");
                    break;
                case 4:
                    //
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                default:
                    break;
            }


            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "Ianuarie");
            month.Add(2, "Februarie");
            month.Add(3, "Martie");
            month.Add(4, "Aprilie");
            month.Add(5, "Mai");
            month.Add(6, "Iunie");
            month.Add(7, "Iulie");
            month.Add(8, "August");
            month.Add(9, "Septembrie");
            month.Add(10, "Octombrie");
            month.Add(11, "Noiembrie");
            month.Add(12, "Decembrie");


            Console.WriteLine(month[n]);

            */
            DateTime dt = new DateTime(2000, n, 1);

            Console.WriteLine(dt.ToString("MMMM", CultureInfo.InvariantCulture));


        }

        private static void suma3MaxDin5()
        {
            string line;
            line = Console.ReadLine();

            char[] seps = { ' ' };
            string[] token = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int a, b, c, d, e;
            int suma;
            int m1, m2, m3; //
            a = int.Parse(token[0]);
            b = int.Parse(token[1]);
            c = int.Parse(token[2]);
            d = int.Parse(token[3]);
            e = int.Parse(token[4]);

            // a
            m1 = a;

            // b
            if (b >= m1)
            {
                m2 = m1;
                m1 = b;
            }
            else
            {
                m2 = b;
            }

            // c
            if (c >= m1)
            {
                m3 = m2;
                m2 = m1;
                m1 = c;
            }
            else if (c >= m2)
            {
                m3 = m2;
                m2 = c;
            }
            else
                m3 = c;

            // d
            if (d >= m1)
            {
                m3 = m2;
                m2 = m1;
                m1 = d;
            }
            else if (d >= m2)
            {
                m3 = m2;
                m2 = d;
            }
            else if (d >= m3)
            {
                m3 = d;
            }


            // e
            if (e >= m1)
            {
                m3 = m2;
                m2 = m1;
                m1 = e;
            }
            else if (e >= m2)
            {
                m3 = m2;
                m2 = e;
            }
            else if (e >= m3)
            {
                m3 = e;
            }


            Console.WriteLine(m1 + m2 + m3);

        }

        private static void minim3()
        {
            string line;
            line = Console.ReadLine();

            char[] seps = { ' ' };
            string[] token = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int a, b, c;
            a = int.Parse(token[0]);
            b = int.Parse(token[1]);
            c = int.Parse(token[2]);


            int minim;
            // varianta 1.
            //minim = Math.Min(a, Math.Min(b, c));


            // varianta 2.
            //minim = a;
            //if (b < minim)
            //{
            //    minim = b;
            //}
            //if (c < minim)
            //{
            //    minim = c;
            //}


            // varianta 3.
            if (a < b)
            {
                minim = a;
                if (c < a)
                {
                    minim = c;
                }
            }
            else
            {
                minim = b;
                if (c < b)
                {
                    minim = c;
                }
            }

            Console.WriteLine(minim);
        }

        private static void interval()
        {
            string line;
            line = Console.ReadLine();

            char[] seps = { ' ' };
            string[] token = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int a, b, x;
            a = int.Parse(token[0]);
            b = int.Parse(token[1]);
            x = int.Parse(token[2]);
            

            /*
            // exemplu pentru short-circuit evaluation
            int i = 1;
            if (i < token.Length && token[i] == "10")
            {
                // bla bla
            }
            */

            if (x >= a && x <= b)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }

        private static void sticle()
        {
            string line;
            line = Console.ReadLine();

            char[] seps = { ' ' };
            string[] token = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int x, y;
            x = int.Parse(token[0]);
            y = int.Parse(token[1]);


            int s;
            s = y / x;
            if (y % x != 0)
            {
                s++;
            }

            Console.WriteLine(s);

        }

        private static void maxim()
        {
            string line;
            //line = Console.ReadLine();

            Stream s = Console.OpenStandardInput();

            StreamReader sr = new StreamReader(s);
            line = sr.ReadToEnd();

            char[] seps = { ' ', '\n', '\r'};
            string[] token = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int a, b;
            a = int.Parse(token[0]);
            b = int.Parse(token[1]);

            //Console.WriteLine(Math.Max(a, b));

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            
        }

        private static void paritate()
        {
            string line;
            line = Console.ReadLine();

            int n;

            n = Convert.ToInt32(line);

            if (n % 2 == 0)
            {
                Console.WriteLine("{0} este par", n);
            }
            else
            {
                Console.WriteLine("{0} este impar", n);
            }
        }
    }
}
