using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Averages()
        {
            Console.WriteLine("Введите текстовую строку: ");
            string Initial = Console.ReadLine();
            int N = Initial.Length;

            double count = 0;
            double n = 0;

            char[] separators = new char[] { ',', '.', '!', '?', ' ' };

            string[] divided = Initial.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach(string item in divided)
            {
                count++;
                n = n + item.Length;
            }

            Console.WriteLine(count);
            Console.WriteLine(n);

            double average = n / count;

            Console.WriteLine($"Средняя длина: {average}");//округления нет.
        }
        static void Main()
        {
            Averages();
        }
    }
}
