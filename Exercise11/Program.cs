using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер 1 массива: ");
            int sizearray = int.Parse(Console.ReadLine());
            int[] iarray = new int[sizearray];
            Random randomforarray = new Random();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < iarray.Length; i++)
            {
                iarray[i] = randomforarray.Next(0, 100);
                Console.Write("{0} ", iarray[i]);
            }

            for (int i = 0; i < iarray.Length; i++)
            {
                for (int j = 0; j < iarray.Length - 1; j++)
                {
                    if (iarray[j] > iarray[j + 1])
                    {
                        int z = iarray[j];
                        iarray[j] = iarray[j + 1];
                        iarray[j + 1] = z;
                    }
                }
            }

            Console.WriteLine("\nРезультат: ");
            Array.Reverse(iarray);
            for (int i = 0; i < iarray.Length; i++)
            {
                Console.Write("{0} ", iarray[i]);
            }
            Console.ReadLine();
        }
    }
}
