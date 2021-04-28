using System;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Task_4._1
{
    public class FileManagement
    {
        public static readonly string Path_to_Catalogue = "C:/Task_4/Task_Catalogue";
        public static readonly string Path_to_Backup_Catalogue = "C:/Task_4/Task_Backup_Catalogue";
        public static readonly string Path_to_Log = "C:/Task_4/Task_Log";

        public void Catalogue_Create()
        {
            if (!Directory.Exists("C:/Task_4"))
            {
                Console.WriteLine("Папка C:/Task_4 не найдена, создать её? y/n ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Directory.CreateDirectory(Path_to_Catalogue);
                    Directory.CreateDirectory(Path_to_Backup_Catalogue);
                    Directory.CreateDirectory(Path_to_Log);
                    Console.Clear();
                }
                else return;
            }
        }

        public void Observer()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(Path_to_Catalogue);
            watcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.Size;

            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true; 
        }

        private void OnChanged(object sourse, FileSystemEventArgs e)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"Файл {e.Name} изменен");

            string New_Path = $"{Path_to_Backup_Catalogue}\\{Path.GetFileName(e.FullPath)}";

            int i = 1;

            do
            {
                New_Path = $"{Path_to_Backup_Catalogue}\\\\{Path.GetFileNameWithoutExtension(e.FullPath)}({i}){Path.GetExtension(e.FullPath)}";
                i = i + 1;
            }
            while (File.Exists(New_Path));

            File.Copy(e.FullPath, New_Path);

            using (StreamWriter sw = new StreamWriter($"{Path_to_Log}\\Log.txt", true))
            {
                sw.WriteLine($"{date}---Изменен---{e.FullPath}");
            }

        }

        static void OnRenamed(object sourse, RenamedEventArgs e)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"Файл {e.OldName} переименован в {e.Name}");

            string New_Path = $"{Path_to_Backup_Catalogue}\\{Path.GetFileName(e.FullPath)}";
            File.Copy(e.FullPath, New_Path);

            Console.WriteLine(New_Path);

            using (StreamWriter sw = new StreamWriter($"{Path_to_Log}\\Log.txt", true))
            {
                sw.WriteLine($"{date}---Переименован---{e.OldFullPath}---{New_Path}");
            }
        }

        static void OnCreated(object sourse, FileSystemEventArgs e)
        {
            DateTime date = DateTime.Now;

            string New_Path = $"{Path_to_Backup_Catalogue}\\{Path.GetFileName(e.FullPath)}";
            File.Copy(e.FullPath, New_Path);

            Console.WriteLine($"Создание файла {e.Name}");
            using (StreamWriter sw = new StreamWriter($"{Path_to_Log}\\Log.txt", true))
            {
                sw.WriteLine($"{date}---Создан---{e.FullPath}");
            }
        }

        static void OnDeleted(object sourse, FileSystemEventArgs e)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"Удаление файла {e.Name}");
            using (StreamWriter sw = new StreamWriter($"{Path_to_Log}\\Log.txt", true))
            {
                sw.WriteLine($"{date}---Удален---{e.FullPath}");
            }
        }


        public void Date_Time_Input()
        {
            Console.WriteLine("Введите дату в формате 'дд.ММ.гггг чч:мм:сс':    ");
            DateTime.TryParse(Console.ReadLine(), out DateTime input);
            Roll_back(input);
        }



        static void Roll_back(DateTime input)
        {
            string[] Log_File = File.ReadAllLines($"{Path_to_Log}\\Log.txt");
            
            foreach(string str in Log_File)
            {
                if(!string.IsNullOrEmpty(str))
                {
                    var date = DateTime.ParseExact(str.Substring(0, 19), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    if(input == date)
                    {
                        string Path = str.Substring(str.LastIndexOf("---") + 3);
                        Console.WriteLine(str);
                        Console.WriteLine(Path);

                       

                    }

                    //var Content = str.Split("---");
                    

                }

            }

        }
    }
}
