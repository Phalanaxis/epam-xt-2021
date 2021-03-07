using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Lowercase()
        {
            Console.WriteLine("Введите строку: ");
            string Initial = Console.ReadLine();

            char[] separators = new char[] { ',', '.', '!', '?', ' ' };
            string[] divided = Initial.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (var item in divided)
            {
                if (Char.IsLower(item[0]))
                {
                    count++;
                }
            }

            Console.WriteLine($"количество слов начинающихся с маленькой буквы: {count}");
        }
        static void Main()
        {
            Lowercase();
        }
    }
}
