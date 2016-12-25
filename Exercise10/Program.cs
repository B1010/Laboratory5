using System;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            Random randomforarray = new Random();
            Console.Write("Введите размер матрицы: ");
            int arraysize = int.Parse(Console.ReadLine());
            int[,] array = new int[arraysize, arraysize];

            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < arraysize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arraysize; j++)
                {
                    array[i, j] = randomforarray.Next(0, 10);
                    Console.Write("{0} ", array[i, j]);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
            Console.WriteLine("\n\nТранспонированная матрица: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
