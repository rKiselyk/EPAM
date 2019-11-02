using System;

namespace Lab1Lib {
    public struct Person {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }

        public Person(string name, string surname, int age) {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string CompareByAge(int n) {
            if (this.Age > n)
                return $"{Name} {Surname} older then {n}";
            return $"{Name} {Surname} yonger then {n}";
        }
    }
}
