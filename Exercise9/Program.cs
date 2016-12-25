using System;

namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            Random randomforarray = new Random();
            int isize = 5, jsize = 5;
            int[,] larray = new int[isize, jsize];
            int[,] iarray = new int[isize, jsize];
            int[,] jarray = new int[isize, jsize];

            for (int i = 0; i < isize; i++)
            {
                for (int j = 0; j < jsize; j++)
                {
                    iarray[i, j] = randomforarray.Next(10);
                    jarray[i, j] = randomforarray.Next(10);
                }
            }

            Console.WriteLine("Сложения матриц:");
            for (int i = 0; i < isize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jsize; j++)
                {
                    larray[i, j] = iarray[i, j] + jarray[i, j];
                    Console.Write("{0}\t", larray[i, j]);
                }
            }

            Console.WriteLine("\n\nВычитание матриц:");
            for (int i = 0; i < isize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jsize; j++)
                {
                    larray[i, j] = iarray[i, j] - jarray[i, j];
                    Console.Write("{0}\t", larray[i, j]);
                }
            }

            Console.WriteLine("\nУмножение матриц:");
            for (int i = 0; i < isize; ++i)
            {
                Console.WriteLine();
                for (int j = 0, sum = 0; j < jsize; ++j)
                {
                    for (int k = 0; k < isize; ++k)
                    {
                        sum += iarray[i, k] * jarray[k, j];
                        larray[i, j] = sum;
                    }
                    Console.Write("{0}\t", larray[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
