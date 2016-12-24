using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0, sizearray = 0;
            double sum = 0;
            Console.Write("Введите размерность массива: ");
            sizearray = int.Parse(Console.ReadLine());
            double[] iarray = new double[sizearray];

            Console.WriteLine("\nВведите элементы массива: ");
            while (temp < sizearray)
            {
                iarray[temp] = double.Parse(Console.ReadLine());
                temp++;
            }

            sum = iarray[0] + iarray[1] + iarray[2];
            for (int i = 1; i < temp - 2; i++)
            {
                if (sum < (iarray[i] + iarray[i + 1] + iarray[i + 2]))
                {
                    sum = iarray[i] + iarray[i + 1] + iarray[i + 2];
                }
            }
            Console.WriteLine("\nМаксимальная сумма = " + sum);
            Console.ReadLine();
        }
    }
}
