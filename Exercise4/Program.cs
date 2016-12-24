using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int one_array, two_array;
            Console.Write("Введите размер 1 массива: ");
            one_array = int.Parse(Console.ReadLine());
            Console.Write("Введите размер 2 массива: ");
            two_array = int.Parse(Console.ReadLine());

            int[] iarray = new int[one_array];
            int[] jarray = new int[two_array];
            int[] larray = new int[one_array + two_array];
            int[] tarray = new int[one_array + two_array];
            int index = 1;
            int count = 0;
            Random randomforarray = new Random();

            Console.Write("\nПервый массив: ");
            for (int i = 0; i < one_array; i++)
            {
                iarray[i] = randomforarray.Next(0, 10);
                Console.Write("{0} ", iarray[i]);
                larray[i] = iarray[i];
            }
            Console.Write("\nВторой массив: ");
            for (int i = 0; i < two_array; i++)
            {
                jarray[i] = randomforarray.Next(0, 10);
                Console.Write("{0} ", jarray[i]);
                larray[one_array + i] = jarray[i];
            }

            for (int i = 0; i < larray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < larray.Length; j++)
                {
                    if (larray[j] < larray[min])
                    {
                        min = j;
                    }
                }
                int temp = larray[min];
                larray[min] = larray[i];
                larray[i] = temp;
            }
            tarray[0] = larray[0];
            for (int i = 1; i < larray.Length; i++)
            {
                if (larray[i] != larray[i - 1])
                {
                    tarray[index] = larray[i];
                    index++;
                }
                else count++;
            }
            Console.Write("\n\nРезультирующий массив: ");
            for (int i = 0; i < tarray.Length - count; i++)
            {
                Console.Write("{0} ", tarray[i]);
            }
            Console.ReadLine();
        }
    }
}
