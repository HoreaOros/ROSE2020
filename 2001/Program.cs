using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2001
{
    class Program
    {
        static void Main(string[] args)
        {
            //PozMinMax();
            //groups2();
            //munte();


            OrdLin();


        }

        private static void OrdLin()
        {
            int n, m;

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(10);
                }
            }


            afis(mat);
            //precalcule;
            int[] v = new int[n];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    suma += mat[i, j];
                }
                v[i] = suma;
            }

            int aux;
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;


                        // inversez linia i si linia j din matrice
                        for (int k = 0; k < mat.GetLength(1); k++)
                        {
                            aux = mat[i, k];
                            mat[i, k] = mat[j, k];
                            mat[j, k] = aux;
                        }
                    }
                }
            }
            afis(mat);



        }

        private static void afis(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void munte()
        {
            int n, j, k;
            n = int.Parse(Console.ReadLine());
            int nr;
            int[] v;
            bool munte;
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());

                v = new int[10];
                j = 0;
                while (nr > 0)
                {
                    v[j++] = nr % 10; // j++ incrementare postfix
                    nr /= 10;
                }
                // verificare muntelui
                munte = true;
                k = 0;
                while (k + 1 < j && v[k] < v[k + 1])
                {
                    k++;
                }
                if (k == 0)
                {
                    munte = false;
                }
                
                if (munte == true)
                {
                    if (k == j - 1)
                    {
                        munte = false;
                    }
                }

                if (munte == true)
                {
                    while (k + 1 < j && v[k] > v[k + 1])
                    {
                        k++;
                    }
                    if (k + 1 != j)
                    {
                        munte = false;
                    }
                }
                if (munte == true)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(0);
            }

            

        }

        private static void groups2()
        {
            //1,2,3,4,5,6
        }

        private static void PozMinMax()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int[] v;

            v = new int[n];

            int imin = 0, imax = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < v[imin])
                {
                    imin = i;
                }
                if (v[i] > v[imax])
                {
                    imax = i;
                }
            }

            Console.WriteLine($"Elementul minim se afla pe pozitia {imin} si are valoarea {v[imin]}");
            Console.WriteLine($"Elementul maxim se afla pe pozitia {imax} si are valoarea {v[imax]}");
        }
    }
}
