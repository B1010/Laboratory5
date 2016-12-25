using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomforarray = new Random();
            int newi, newj;
            double[,] iarray = new double[9, 9];
            double[,] jarray = new double[3, 3];
            
            Console.WriteLine("Массив 9:9, состав: ");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    iarray[i, j] = randomforarray.Next(0, 10);
                    Console.Write("{0} ", iarray[i, j]);
                }
            }
            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (i <= 2)
                        newi = 0;
                    else
                    {
                        if (i > 2 && i <= 5) newi = 1;
                        else newi = 2;
                    }
                    if (j <= 2) newj = 0;
                    else
                    {
                        if (j > 2 && j <= 5) newj = 1;
                        else newj = 2;
                    }
                    jarray[newi, newj] = jarray[newi, newj] + iarray[i, j];
                }
            }
            Console.WriteLine("\n\nМассив 3:3, состав:  ");
            for (int i = 0; i < jarray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jarray.GetLength(1); j++)
                {
                    Console.Write("{0} ", jarray[i, j]);
                }
            }
            Console.ReadLine();

        }
    }
}
