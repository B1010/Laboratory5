using System;

namespace Exercise7
{
    class Program
    {
        static void Main()
        {
            int n = 5;
            int[,] array = new int[10, 5];
            int[,] result = new int[10, 5];
            int[] vector = new int[] { 3, 2, 5, 4, 1 };
            Random randomforarray = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = randomforarray.Next(0, 10);
                }
            }
            Console.WriteLine("Результат: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = array[vector[i] - 1, j];
                    Console.Write(result[i, j] + " ");
                }
            }
            Console.Read();
        }
    }
}
