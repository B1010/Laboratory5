using System;

namespace Exercise5
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

            Console.WriteLine("Введите элементы массива: ");
            while (temp < sizearray)
            {
                iarray[temp] = double.Parse(Console.ReadLine());
                temp++;
            }

            double min = sum = iarray[0] + iarray[iarray.Length - 1];
            for (int i = 0; i < iarray.Length; i++)
            {
                sum = iarray[i] + iarray[iarray.Length - 1 - i];
                if (sum < min)
                    min = sum;
            }
            Console.WriteLine("Минимум = {0}", min);
            Console.ReadLine();

        }
    }
}
