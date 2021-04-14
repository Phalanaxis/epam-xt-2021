using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество людей:  ");
            int.TryParse(Console.ReadLine(), out int Circle_Size);
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:    ");
            int.TryParse(Console.ReadLine(), out int N);
            Weakest_Link Launch = new Weakest_Link(Circle_Size, N);
            Launch.Program_Start();

        }
    }


    class Weakest_Link
    {
        private List<Circle_of_People> Circle;

        public int Updated_N;

        public Weakest_Link(int Circle_Size, int N)
        {
           
            Circle = new List<Circle_of_People>(Circle_Size);
            Updated_N = N;
            Add_Elements();
        }

        public void Add_Elements()
        {
            for (int i = 0; i < Circle.Capacity; i++)
            {
                Console.WriteLine("тут");
                Circle.Add(new Circle_of_People(i));
            }
        }

        public void Program_Start()
        {
            Console.WriteLine("тут1");
            bool Check = true;
            while (Check)
            {
                if (Circle.Count > 0 && Updated_N > 0 && Circle.Count > Updated_N)
                {
                    Check = false;
                }
                else
                {
                    Console.WriteLine("неверно введены параметры");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            int index = 0;
            int Counter = 0;
            while (Circle.Count >= Updated_N)
            {
                Circle.RemoveAt((index + Updated_N) % Circle.Count);
                index = (index + Updated_N) % Circle.Count;

                Counter++;
                if (Counter > 0)
                {
                    Console.WriteLine($"Раунд  {Counter}" + $" Вычеркнут человек. Людей осталось: {Circle.Count}");
                }
            }

            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }
    }
}
