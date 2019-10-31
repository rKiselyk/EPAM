using System;
using System.Text.RegularExpressions;
using AdditionClasses;

namespace Lab7Lib {
    public class ConsoleCalculator {

        /// <summary>
        /// Method that returns the result of the entered expression \n
        /// <para>Input: string expression</para>
        /// </summary>
        /// <param name="expresion"></param>
        /// <returns></returns>
        public static double Calculate(string expresion) {
            double result = 0;

            string number = "";
            for (int i = 0; i < expresion.Length; ++i) {
                if (Char.IsDigit(expresion[i])) {
                    number += expresion[i];
                }
                else {
                    switch (expresion[i]) {
                        case '+':
                            result = ConsoleCalculator.Add(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                            break;
                        case '-':
                            result = ConsoleCalculator.Minus(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                            break;
                        case '*':
                            result = ConsoleCalculator.Multiplication(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                            break;
                        case '/':
                            result = ConsoleCalculator.Divine(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                            break;
                    }
                }

            }

            return result;
        }

        static int Add(int first, int second) => first + second;
        static int Minus(int first, int second) => first - second;
        static double Multiplication(int first, int second) => first * second;
        static double Divine(int first, int second) => first / second;
    }
}
