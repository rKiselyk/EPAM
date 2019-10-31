using System;
using System.IO;
using System.Collections.Generic;
using AdditionClasses;
using Lab3Lib;
using Lab4Lib;
using Lab5Lib;
using Lab6Lib;
using Lab7Lib;

namespace LabSelect {
    class Program {
        static void Main(string[] args) {
            IPrinter consolePrinter = new ConsolePrinter();

            consolePrinter.WriteLine("Enter number of lab: ");
            switch (consolePrinter.ReadLine()) {
                case "3":
                    try {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName);

                        DirectoryVisualizer.PrintSubDir(dir, consolePrinter);
                        consolePrinter.WriteLine("-------");
                        DirectoryVisualizer.FindLocationOfFileByPartName("ogram", dir, consolePrinter);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                    }

                    break;

                case "4":
                    List<Car> cars = new List<Car>() { new Car("car1","01","black"),
                                                       new Car("car2","02","white"),
                                                       new Car("car3","04","black"),
                                                       new Car("car4","03","yellow")};
                    try {
                        Serializer.ToXML("Cars.xml", cars, typeof(List<Car>));
                        Serializer.ToBinary("Cars.dat", cars);
                        Serializer.ToJSON("Cars.json", cars);

                        foreach (Car cs in (List<Car>)Deserializer.FromBinary("Cars.dat"))
                            consolePrinter.WriteLine(cs.ToString());
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                    }
                    break;

                case "5":
                    try {
                        PrintInfo.PrintInfoAssembly(consolePrinter);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                    }
                    break;

                case "6":
                    try {
                        consolePrinter.WriteLine(ConsoleCalculator.Calculate(consolePrinter.ReadLine()).ToString());
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                    }
                    break;

                default:
                    consolePrinter.WriteLine("Invalid number");
                    break;
            }
            


            //Console.WriteLine("Hello World!");
        }
    }
}
