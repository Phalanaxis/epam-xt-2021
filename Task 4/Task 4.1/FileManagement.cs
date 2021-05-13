using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;


namespace Task_4._1
{
    public class FileManagement
    {
        public static readonly string Path_to_Catalogue = "C:/Task_4/Task_Catalogue";
        public static readonly string Path_to_Backup_Catalogue = "C:/Task_4/Task_Backup_Catalogue";
        public static readonly string Path_to_Log = "C:/Task_4";

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

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true; 
        }


        private void OnChanged(object sourse, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss");
            Backup_Creation(date);

            Log_update(e.FullPath, 1, date);
        }

        private void OnRenamed(object sourse, RenamedEventArgs e)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss");
            Backup_Creation(date);

            Log_update(e.FullPath, 2, date);
        }

        private void OnCreated(object sourse, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss");
            Backup_Creation(date);

            Log_update(e.FullPath, 3, date);
        }

        private void OnDeleted(object sourse, FileSystemEventArgs e)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss");
            Backup_Creation(date);

            Log_update(e.FullPath, 4, date);
        }

        private void Backup_Creation(string date)
        {
            string New_Path = $"{Path_to_Backup_Catalogue}\\\\{date}";
            Directory.CreateDirectory(New_Path);
            FileSystem.CopyDirectory(Path_to_Catalogue, New_Path);
        }


        private void Log_update(string path, int action, String date)
        {
            using (StreamWriter sw = new StreamWriter($"{Path_to_Log}\\Log.txt", true))
            {
                switch (action)
                {
                    case 1:
                        sw.WriteLine($"{date}---Изменен---{path}");
                        return;
                    case 2:
                        sw.WriteLine($"{date}---Переименован---{path}");
                        return;
                    case 3:
                        sw.WriteLine($"{date}---Создан---{path}");
                        return;
                    case 4:
                        sw.WriteLine($"{date}---Удален---{path}");
                        return;
                }
            }   
        }


        public void Roll_Back_Start()
        {
            Console.WriteLine("Сохраненные точки востановления:    ");
            Get_Directories();

            Console.WriteLine("Введите дату в формате 'дд.ММ.гггг_чч.мм.сс':    ");
            string input = Console.ReadLine();
            
            Roll_back(input);
        }

        private void Get_Directories()
        {
            string[] files = Directory.GetDirectories($"{Path_to_Backup_Catalogue}");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }


        public void Roll_back(string input)
        {
            string path = $"{Path_to_Backup_Catalogue}\\\\{input}";

            if (Directory.Exists(path))
            {
                Directory.Delete(Path_to_Catalogue);
                Directory.CreateDirectory(Path_to_Catalogue);

                DirectoryInfo dir = new DirectoryInfo(path);

                foreach (FileInfo file in dir.GetFiles())
                {
                    file.CopyTo(Path.Combine(Path_to_Catalogue, file.Name), true);
                }
            }
        }
    }
}
