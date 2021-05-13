using System;
using System.IO;

namespace Task_4._1
{
    class Program
    {
        static void Main()
        {
            var file_manager = new FileManagement();

            file_manager.Catalogue_Create();

            Console.WriteLine("Какой из режимов вы желаете включить:" + Environment.NewLine +
                "1: режим наблюдения;" + Environment.NewLine + "2: режим отката изменений;" + Environment.NewLine +
                "3: Выход;");
            
            int.TryParse(Console.ReadLine(), out int caseSwitch);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Включен режим наблюдения");

                    file_manager.Observer();
                    while(Console.ReadKey().Key != ConsoleKey.Escape);
                    return;
                case 2:
                    Console.WriteLine("Включен режим отката изменений");
                    file_manager.Roll_Back_Start();
                    return;
                case 3:
                    break;
                default:
                    return;
            }
        }
    }
}
