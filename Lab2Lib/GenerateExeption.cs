using System;

namespace Lab2Lib {
    public class GenerateExeption {
        public static void StackOverflow_ExseptionGenerete() {
            try {
                StackOverflow_ExseptionGenerete();
            }
            catch (StackOverflowException e) {
                Console.WriteLine($"StackOverflowException: {e.Message}");
            }
        }
        public static void IndexOuOfRange_ExceptionGenerate(int[] array, int index) {
            try {
                Console.WriteLine(array[index]);
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            }
        }
        public static void DoSomeMath(int a, int b) {
            try { }
            catch (ArgumentException e)
            when (a <= 0) { Console.WriteLine($"Parameter shoud be greater then 0, {a}: {e.Message}"); }
            catch (ArgumentException e)
            when (b >= 0) { Console.WriteLine($"Parameter shoud be less then 0, {b}: {e.Message}"); }
        }
    }
}
