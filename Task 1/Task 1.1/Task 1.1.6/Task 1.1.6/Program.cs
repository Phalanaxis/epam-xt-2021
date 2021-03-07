using System;
using System.Collections.Generic;

namespace Task_1._1._6
{
    class Program
    {
        static void Font_adjustment()
        {
            List<string> Fonts = new List<string>();

            while (true)
            {
                Console.WriteLine("Введите: ");
                Console.WriteLine("     1: bold ");
                Console.WriteLine("     2: italic ");
                Console.WriteLine("     3: underline ");
                Console.WriteLine("     4: Выход из программы");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    switch (number)
                    {
                        case 1:
                            if (Fonts.Contains("bold"))
                            {
                                Fonts.Remove("bold");
                            }
                            else
                            {
                                Fonts.Add("bold");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Fonts));
                            break;
                        case 2:
                            if (Fonts.Contains("italic"))
                            {
                                Fonts.Remove("italic");
                            }
                            else
                            {
                                Fonts.Add("italic");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Fonts));
                            break;
                        case 3:
                            if (Fonts.Contains("underline"))
                            {
                                Fonts.Remove("underline");
                            }
                            else
                            {
                                Fonts.Add("underline");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Fonts));
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Неверная команда.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение, нажмите любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void Main()
        {
            Font_adjustment();
        }
    }
}
