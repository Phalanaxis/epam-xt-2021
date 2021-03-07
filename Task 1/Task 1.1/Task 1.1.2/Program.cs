using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Triangle()
        {
            Console.WriteLine("Введите число строк N: ");
            int.TryParse(Console.ReadLine(), out int N);

            for(int Height = 0; Height < N; Height++)
            {
                
                for(int Length = 0; Length <= Height; Length++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Triangle();
        }
    }
}
