using System;

namespace Task_1._1._4
{
    class Program
    {
        static void xmas_tree()
        {
            Console.WriteLine("Введите число N: ");
            int.TryParse(Console.ReadLine(), out int N);

            for (int current_triangle = 0; current_triangle <= N; current_triangle++)
            {
                for (int Height = 0; Height <= current_triangle; Height++)
                {
                    for (int First_length = 0; First_length <= (N - Height - 1); First_length++)
                    {
                        Console.Write(" ");
                    }
                    for (int Second_length = 0; Second_length < (Height * 2 + 1); Second_length++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main()
        {
            xmas_tree();
        }
    }
}
