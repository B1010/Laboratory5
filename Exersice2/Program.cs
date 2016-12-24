using System;

namespace Exersice2
{
    class Program
    {
        static void Main()
        {
            double[] iarray = new double[10];
            int temp = 0;
            double sum = 0;

            Console.WriteLine("Введите элементы массива: ");
            while (temp < 10)
            {
                iarray[temp] = double.Parse(Console.ReadLine());
                temp++;
            }

            double min = iarray[0];
            foreach (int i in iarray)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            double max = iarray[0];
            foreach (int i in iarray)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            int MinIndex = 0, MaxIndex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (iarray[i] == min)
                    MinIndex = i;
                if (iarray[i] == max)
                    MaxIndex = i;
            }

            if (MaxIndex > MinIndex)
            {
                for (int i = MinIndex + 1; i <= MaxIndex - 1; i++)
                {
                    sum = sum + iarray[i];
                }
                Console.WriteLine("Сумма между min и max = {0}", sum);
            }
            else
            {
                Console.WriteLine("Максимальный элемент встречается раньше минимального");
            }
            Console.ReadLine();
        }
    }
}
