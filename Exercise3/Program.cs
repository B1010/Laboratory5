using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] iarray = new double[10];
            int temp = 0, max = 0;

            Console.WriteLine("Введите элементы массива: ");
            while (temp < 10)
            {
                iarray[temp] = double.Parse(Console.ReadLine());
                temp++;
            }

            for (int i = 0, temp2 = 1; i <= 9; i++)
            {
                if (i != 9)
                {
                    if (iarray[i] < iarray[i + 1])
                        temp2++;
                    else
                    {
                        if (temp2 > max)
                            max = temp2;
                        temp2 = 1;
                    }
                }
                else
                {
                    if (temp2 > max)
                        max = temp2;
                }
            }
            Console.WriteLine("Максимальная длинна возрастающей цепочки чисел идущих подряд: {0}", max);
            Console.ReadLine();
        }
    }
}
