using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || i == array.GetLength(0) - 1)
                        array[i, j] = 1;
                    if ((i == 1 || i == 3) && (j >= 1 && j <= 3))
                        array[i, j] = 1;
                    if ((i == 2 || i == 2) && (j >= 2 && j <= 2))
                        array[i, j] = 1;
                    if (i == 1 && j == 1)
                        array[i, j] = 1;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
