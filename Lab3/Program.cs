using System;
using System.IO;

/*
    1. Вивести на екран вміст заданого каталогу у вигляді
    списку файлів, піддиректорій з вмістом цих
    директорій .
    2. Створіть додаток, який дозволяє знайти по частково-
    заданому імені файл з розширенням .txt
    логер ду будуть всі помилки і записати в в файл
*/

namespace Lab3 {

    class DirectoryVisualizer {

    }
    class Program {

        public static void PrintSubDir(DirectoryInfo dir) {
            DirectoryInfo[] subDir = dir.GetDirectories();
            foreach (DirectoryInfo dirinfo in subDir) {
                Console.WriteLine(dirinfo);
                foreach (var file in dirinfo.GetFiles())
                    Console.WriteLine(file);
                PrintSubDir(dirinfo);
            }
        }

        public static void FindAll(DirectoryInfo dir, string partName) {
            DirectoryInfo[] subDir = dir.GetDirectories();
            foreach (DirectoryInfo dirinfo in subDir) {
                //Console.WriteLine(dirinfo);
                foreach (var file in dirinfo.GetFiles())
                    if (file.Name == partName)
                        Console.WriteLine(file);
                FindAll(dirinfo, partName);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            DirectoryInfo dir = new DirectoryInfo(@"D:\C#\EPAM");
            //DirectoryInfo[] subDir = dir.GetDirectories();
            //foreach (DirectoryInfo dirinfo in subDir)
            //    Console.WriteLine(dirinfo);
            PrintSubDir(dir);
            FindAll(dir, "TestFile.txt");
        }
    }
}
