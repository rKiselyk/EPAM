using System;
using System.IO;

namespace AdditionClasses {
    public interface IPrinter {
        string ReadLine();
        void WriteLine(string str);
    }

    public class ConsolePrinter : IPrinter {
        public void WriteLine(string str) { Console.WriteLine(str); }
        public void Write(string str) { Console.Write(str); }
        public string ReadLine() { return Console.ReadLine(); }
    }

    public class FilePrinter : IPrinter {
        public string Path { get; set; }

        public FilePrinter(string path) {
            Path = path;
        }

        public void WriteLine(string str) {
            using (StreamWriter file = new StreamWriter(Path,true)) {
                file.WriteLine(str);
            }
        }
        public string ReadLine() { return ""; }
    }
}
