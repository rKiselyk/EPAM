using System;
using System.IO;
using AdditionClasses;
using System.Text;

namespace Lab3Lib {
    public class DirectoryVisualizer {
        public static void PrintSubDir(DirectoryInfo dir, IPrinter printer) {
            try {
                foreach (DirectoryInfo dirinfo in dir.GetDirectories()) {
                    //printer.WriteLine(dirinfo);
                    foreach (var file in dirinfo.GetFiles())
                        //printer.WriteLine(file);
                    PrintSubDir(dirinfo, printer);
                }
            }
            catch (DirectoryNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            } 
        }
        public static void FindLocationOfFileByPartName(string partName, DirectoryInfo directory, IPrinter printer) {
            foreach (var file in directory.GetFiles("*" + partName + "*"))
                printer.WriteLine(file.FullName);
            foreach (var subDir in directory.GetDirectories())
                FindLocationOfFileByPartName(partName,subDir,printer);
        }
    }
}
