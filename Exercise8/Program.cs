using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, k = 0;
            int[] arrayline = new int[10];
            int[] arraycolu = new int[10];
            int[,] iarray = new int[10,10];
            Random randomforarray = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    iarray[i, j] = randomforarray.Next(10);
                }
            }

            for (int i = 0; i < 10; i++, k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += iarray[i, j];
                }
                arrayline[k] = sum;
                sum = 0;
            }
            int maxstr = arrayline[0];
            for (int g = 0; g < 10; g++)
            {
                if (maxstr < arrayline[g])
                {
                    maxstr = arrayline[g];
                }
            }
            sum = 0;
            for (int i = 0, f = 0; i < 10; i++, f++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += iarray[j, i];
                }
                arraycolu[f] = sum;
                sum = 0;
            }
            int maxstb = arraycolu[0];
            for (int b = 0; b < 10; b++)
            {
                if (maxstb < arraycolu[b])
                {
                    maxstb = arraycolu[b];
                }

            }
            Console.WriteLine("Максимальное значение по сумме строчек = {0}", maxstr);
            Console.WriteLine("Максимальное значение по сумме столбцов = {0}", maxstb);
            Console.ReadLine();

        }
    }
}
