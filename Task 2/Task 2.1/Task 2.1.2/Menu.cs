using System;
using System.Collections.Generic;
using System.Text;
using Task_2._1._2;

namespace Task_2._1._2
{
    class Menu_variety
    {
        public void Options()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1.  Добавить фигуру");
                Console.WriteLine("2.  Вывести фигуры");
                Console.WriteLine("3.  Очистить");
                Console.WriteLine("4.  Выход");

                int.TryParse(Console.ReadLine(), out int First_Option);

                switch (First_Option)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры: ");
                        Console.WriteLine("1.  Линия");
                        Console.WriteLine("2.  Треугольник");
                        Console.WriteLine("3.  Квадрат");
                        Console.WriteLine("4.  Прямоугольник");
                        Console.WriteLine("5.  Окружность");
                        Console.WriteLine("6.  Круг");
                        Console.WriteLine("7.  Кольцо");

                        int.TryParse(Console.ReadLine(), out int Second_Option);

                        switch (Second_Option)
                        {
                            case 1:
                                Choosen_Option.Choice_Line();
                                //caseTo1.Choice_Line(List_of_figures);
                                break;
                            case 2:
                                Choosen_Option.Choice_Triangle();
                                break;
                            case 3:
                                Choosen_Option.Choice_Square();
                                break;
                            case 4:
                                Choosen_Option.Choice_Rectangle();
                                break;
                            case 5:
                                Choosen_Option.Choice_Circle();
                                break;
                            case 6:
                                Choosen_Option.Choice_Disk();
                                break;
                            case 7:
                                Choosen_Option.Choice_Ring();
                                break;
                        }
                        break;
                    case 2:
                        Choosen_Option.Output();
                        break;
                    case 3:
                        Console.Clear();
                        Choosen_Option.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("выход");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
