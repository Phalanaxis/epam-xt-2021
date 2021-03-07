using System;
using System.Text;

namespace Task_1._2._2
{
    class Program
    {
        static void Doubler()
        {
            Console.WriteLine("Введите первую строку: ");
            string First = Console.ReadLine();

            Console.WriteLine("Введите вторую строку: ");
            string Second = Console.ReadLine();

            string FinalString = string.Empty;

            foreach (var item in First)
            {
                FinalString = FinalString + item;
                if (Second.Contains(item))
                {
                    FinalString = FinalString + item;
                }
            }
            Console.WriteLine(FinalString);
        }
        static void Main()
        {
            Doubler();
        }
    }
}
