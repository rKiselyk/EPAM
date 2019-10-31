using System;
using AdditionClasses;

namespace LoggerLib {
    interface ILogger {
        void WriteMsg(string messege);
        string ReadMsg();
    }

    public class Logger : ILogger {
        public IPrinter Sourse { get; set; }

        public Logger(IPrinter sourse) {
            Sourse = sourse;
        }

        public string ReadMsg() {
            return Sourse.ReadLine();
        }

        public void WriteMsg(string messege) {
            Sourse.WriteLine(messege);
        }
    }
}
