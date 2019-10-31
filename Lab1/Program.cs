using System;
using System.Linq;

namespace Lab1 {

    interface IPrinter {
        void ReadLine();
        void WriteLine(object str);
    }
    class ConsolePrinter : IPrinter {
        public void WriteLine(object str) { Console.WriteLine(str); }
        public void ReadLine() { Console.ReadLine(); }
    }


    struct Person {
        string Name { get; set; } 
        string Surname { get; set; }
        int Age { get; set; }

        public Person(string name, string surname, int age) {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string CompareByAge(int n){
            if (this.Age > n)
                return $"{Name} {Surname} older then {n}";
            return $"{Name} {Surname} yonger then {n}";
        }
    }

    interface ISize {
        int Height { get; set; }
        int Weight { get; set; }
        int Perimeter();
    }
    interface ICordinates {
        int X { get; set; }
        int Y { get; set; }
    }
    struct Rectangle : ISize, ICordinates {
        public int Height { get; set; }
        public int Weight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle(int x, int y, int height, int weight) {
            X = x;
            Y = y;
            Height = height;
            Weight = weight;
        }

        public int Perimeter() {
            return 2 * (Height + Weight);
        }
    }

    enum Month {Jan ,Feb,Mar,Apr,May, Jun,Jul,Aug,Sep,Oct,Nov,Dec }
    public enum Color {Red = 4,Blue = 15,Green = 1,Yellow = 5 }
    public static class Extention {
        public static void PrintAllByOrder(this Enum curEnum, int n) {
            Array.Sort(Enum.GetValues(typeof(Color)));
            foreach (Color col in Enum.GetValues(typeof(Color)))
                Console.WriteLine(col);
                
        }
        public static Array OrderRowValues(this Enum enumerable, Type type) {
            var values = Enum.GetValues(type);
            Array.Sort(values);
            return values;
        }
    }
    enum LongRange:long { Min = -9223372036854775807, Max = 9223372036854775807 }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            IPrinter ptr1 = new ConsolePrinter();

            //Person personTest = new Person(Console.ReadLine(),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine(personTest.CompareByAge(Convert.ToInt32(Console.ReadLine())));

            //Rectangle rectangleTest = new Rectangle(0, 0, 10, 20);
            //Console.WriteLine($"Perimeter of rectangle with height: {rectangleTest.Height}  {rectangleTest.Perimeter()}");

            //Console.WriteLine(Enum.GetName(typeof(Month),Convert.ToInt32(Console.ReadLine())));



            ptr1.WriteLine($"Max: {(long)LongRange.Max}, Min: {(long)LongRange.Min}");
        }
    }
}
