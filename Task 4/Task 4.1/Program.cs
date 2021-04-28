using System;
using System.IO;

namespace Task_4._1
{
    class Program
    {
        static void Main()
        {
            var Initial = new FileManagement();

            Initial.Catalogue_Create();

            Console.WriteLine("Какой из режимов вы желаете включить:    ");
            Console.WriteLine("1: режим наблюдения;");
            Console.WriteLine("2: режим отката изменений;");
            Console.WriteLine("3: выход;");

            int.TryParse(Console.ReadLine(), out int caseSwitch);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Включен режим наблюдения");

                    Initial.Observer();
                    while(Console.ReadKey().Key != ConsoleKey.Escape);
                    break;
                case 2:
                    Console.WriteLine("Включен режим отката изменений");
                    Initial.Date_Time_Input();
                    break;
                default:
                    return;
            }
        }
    }
}
