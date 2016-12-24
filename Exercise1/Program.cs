using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2
{
    class Program
    {
        static void Main()
        {
            int[,] iarray = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    iarray[i, j] = random.Next(1000);
                }
            }

            double max = iarray[0, 0];
            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (max < iarray[i, j])
                    {
                        max = iarray[i, j];
                    }
                }
            }

            double min = iarray[0, 0];
            for (int i = 0; i < iarray.GetLength(0); i++)
            {
                for (int j = 0; j < iarray.GetLength(1); j++)
                {
                    if (min > iarray[i, j])
                    {
                        min = iarray[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальное значение {0}\nМаксимальное значение {1}", min, max);
            Console.ReadLine();
        }
    }
}
