using System;

namespace Task_1._1._7
{
    class Program
    {
        static void Array_prossesing()
        {
            Console.WriteLine("Введите размер массива: ");
            int.TryParse(Console.ReadLine(), out int n);
            int[] array = new int[n];

            int pros;

            Random r = new Random();
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = r.Next(-100, 100);
                Console.Write($"{array[a]}    ");
            }

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    if (array[a] > array[b])         
                    {
                        pros = array[a];
                        array[a] = array[b];
                        array[b] = pros;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный масив:      ");

            for (int a = 0; a < array.Length; a++)
            {
                Console.Write($"{array[a]}      ");
            }


            int max = array[0];
            int min = array[0];

            foreach (int num in array)
            {
                if (max < num)
                {
                    max = num;
                }
                else if (min > num)
                {
                    min = num;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Min:{0}", min);
            Console.WriteLine("Max:{0}", max);
        }
        static void Main()
        {
            Array_prossesing();
        }
    }
}
