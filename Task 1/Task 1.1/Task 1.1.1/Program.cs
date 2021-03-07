using System;

namespace Task_1._1._1
{
    class Rectangle 
    {
        static int ReadInteger(string Initial)
        {
            while(true)
            {
                Console.WriteLine(Initial);

                if (int.TryParse( Console.ReadLine(), out int number ) )
                {
                    if(number <= 0)
                    {
                        Console.Write("Значение должно быть больше нуля. ");
                    }
                    else
                    {
                        return number;
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

        static void MethodRectangle(int A, int B)
        {
            int S = A * B;
            Console.WriteLine($"Площадь прямоугольника равна: {S}");
        }

        static void Main()
        {
            int A = ReadInteger("Введите число A: ");
            int B = ReadInteger("Введите число B: ");
            
            if(A == B)
            {
                Console.WriteLine("Вы ввели квадрат!");
            }
            
            MethodRectangle(A, B);
        }
    }
}
