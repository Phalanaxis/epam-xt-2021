using System;

namespace Task_1._1._10
{
    class Program
    {
        static void array()
        {
            int[,] array = new int[4,5];
            Random r = new Random();

            int sum = 0;

            for(int a = 0; a<array.GetLength(0); a++)
            {
                for(int b = 0; b < array.GetLength(1); b++)
                {
                    array[a, b] = r.Next(-10, 10);

                    Console.Write($"{array[a, b]}    ");

                    if ((a + b) % 2 == 0)
                    {
                        sum = sum + array[a, b];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов: {sum}");

        }
        static void Main()
        {
            array();
        }
    }
}
