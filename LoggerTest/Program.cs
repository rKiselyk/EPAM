using System;
using AdditionClasses;
using LoggerLib;

namespace LoggerTest {
    class Program {
        static void Main(string[] args) {

            IPrinter printer = new ConsolePrinter();
            IPrinter filePrinter = new FilePrinter(@"D:\C#\EPAM\LoggerTest\log.txt");
            Logger logger = new Logger(filePrinter);

            int zero = 0;
            try {
                int a = 3 / zero;
            }
            catch (Exception e) {
                logger.WriteMsg($"{DateTime.Now} - {e.Message}");
            }

            
            //Console.WriteLine("Hello World!");
        }
    }
}
