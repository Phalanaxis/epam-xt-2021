using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Non_negative()
        {
            Console.WriteLine("Введите размерность массива: ");
            int.TryParse(Console.ReadLine(), out int n);
            int[] array = new int[n];
            Random r = new Random();
            int sum = 0;
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = r.Next(-10, 10);
                Console.Write($"{array[a]}    ");

                if (array[a] > 0)
                {
                    sum += array[a];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"сумма элементов: {sum}   ");

        }
        static void Main()
        {
            Non_negative();
        }
    }
}
