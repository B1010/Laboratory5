using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] iARRAY = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    iARRAY[i, j] = random.Next(100);
                    Console.Write("{0,9}", iARRAY[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("max {0}", iARRAY.Max());

        }
    }
}
