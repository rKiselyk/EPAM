using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using AdditionClasses;
using LoggerLib;
using Lab1Lib;
using Lab2Lib;
using Lab3Lib;
using Lab4Lib;
using Lab5Lib;
using Lab6Lib;
using Lab7Lib;
using Lab8Lib;

namespace LabSelect {

    enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
    enum Color { Red = 4, Blue = 15, Green = 1, Yellow = 5 }
    enum LongRange : long { Min = -9223372036854775807, Max = 9223372036854775807 }

    class Program {
        static void Main(string[] args) {
            IPrinter consolePrinter = new ConsolePrinter();
            Logger logger = new Logger(new FilePrinter("log.txt"));
            Stopwatch watch = new Stopwatch();

            consolePrinter.WriteLine("Enter number of lab: ");
            switch (consolePrinter.ReadLine()) {
                case "1":
                    watch.Start();

                    try {
                        Person personTest = new Person(Console.ReadLine(),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(personTest.CompareByAge(Convert.ToInt32(Console.ReadLine())));

                        Lab1Lib.Rectangle rectangleTest = new Lab1Lib.Rectangle(0, 0, 10, 20);
                        Console.WriteLine($"Perimeter of rectangle with height: {rectangleTest.Height}  {rectangleTest.Perimeter()}");

                        Console.WriteLine(Enum.GetName(typeof(Month),Convert.ToInt32(Console.ReadLine())));



                        consolePrinter.WriteLine($"Max: {(long)LongRange.Max}, Min: {(long)LongRange.Min}");
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed); ;
                    break;

                    break;

                case "2":
                    try {
                        GenerateExeption.StackOverflow_ExseptionGenerete();
                        GenerateExeption.IndexOuOfRange_ExceptionGenerate(new int[] { 0, 1, 2, 3, 4 }, 5);
                        GenerateExeption.DoSomeMath(-3, 3);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }
                    break;

                case "3":
                    watch.Start();

                    try {
                        DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName);

                        DirectoryVisualizer.PrintSubDir(dir, consolePrinter);
                        consolePrinter.WriteLine("-------");
                        DirectoryVisualizer.FindLocationOfFileByPartName("ogram", dir, consolePrinter);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed);;
                    break;

                case "4":
                    List<Car> cars = new List<Car>() { new Car("car1","01","black"),
                                                       new Car("car2","02","white"),
                                                       new Car("car3","04","black"),
                                                       new Car("car4","03","yellow")};
                    watch.Restart();

                    try {
                        Serializer.ToXML("Cars.xml", cars, typeof(List<Car>));
                        Serializer.ToBinary("Cars.dat", cars);
                        Serializer.ToJSON("Cars.json", cars);

                        foreach (Car cs in (List<Car>)Deserializer.FromBinary("Cars.dat"))
                            consolePrinter.WriteLine(cs.ToString());
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed);
                    break;

                case "5":
                    watch.Restart();

                    try {
                        PrintInfo.PrintInfoAssembly(consolePrinter);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed);
                    break;

                case "7":
                    watch.Restart();

                    try {
                        Calculator.Calculate(consolePrinter.ReadLine().ToString(),consolePrinter);
                    }
                    catch (Exception e) {
                        consolePrinter.WriteLine(e.Message);
                        logger.WriteMsg(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed);
                    break;

                case "8":
                    watch.Restart();

                    try {
                        watch.Start();
                        consolePrinter.WriteLine(MatrixOperation.sumInThread(MatrixOperation.GenerateMatrix(1000, 1000), 10).ToString());
                        watch.Stop();
                    }
                    catch (Exception e) {
                        logger.WriteMsg(e.Message);
                        consolePrinter.WriteLine(e.Message);
                    }

                    watch.Stop();
                    consolePrinter.WriteLine("Time: " + watch.Elapsed.ToString());
                    break;

                default:
                    consolePrinter.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
