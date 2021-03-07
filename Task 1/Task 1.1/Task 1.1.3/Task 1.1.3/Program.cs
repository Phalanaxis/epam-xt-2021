using System;

namespace Task_1._1._3
{
    class Program
    {
        static void Another_Triangle()
        {
            Console.WriteLine("Введите число строк N: ");
            int.TryParse(Console.ReadLine(), out int N);

            for(int Height = 0; Height < N; Height++)
            {
                for (int First_length = 0; First_length < (N - Height - 1); First_length++)
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



        static void Main()
        {
            Another_Triangle();
        }
    }
}
