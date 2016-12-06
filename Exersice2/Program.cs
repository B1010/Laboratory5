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
            int[,] iARRAY = new int[10, 10];
            int imax, jmax, imin, jmin;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    iARRAY[i, j] = random.Next(1000);
                }
            }

            double max = iARRAY[0, 0];
            for (int i = 0; i < iARRAY.GetLength(0); i++)
            {
                for (int j = 0; j < iARRAY.GetLength(1); j++)
                {
                    if (max < iARRAY[i, j])
                    {
                        max = iARRAY[i, j];
                        imax = i, jmax = j;
                    }
                }
            }

            double min = iARRAY[0, 0];
            for (int i = 0; i < iARRAY.GetLength(0); i++)
            {
                for (int j = 0; j < iARRAY.GetLength(1); j++)
                {
                    if (min > iARRAY[i, j])
                    {
                        min = iARRAY[i, j];
                        imin = i, imin = j;
                    }
                }
            }
            Console.WriteLine("Минимальное значение {0}, Индекс: {1}{2}. Максимальное значение {3}, Индекс: {4}{5}", min, imax, jmax, max);
            Console.ReadLine();
        }
    }
}
