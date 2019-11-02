using System;
using System.Text.RegularExpressions;
using AdditionClasses;

namespace Lab7Lib {
    public class Calculator {

        /// <summary>
        /// Method that returns the result of the entered expression \n
        /// <para>Input: string expression</para>
        /// </summary>
        /// <param name="expresion"></param>
        /// <returns></returns>
        public static void Calculate(string expresion, IPrinter printer) {
            double result = 0;

            try {
                string number = "";
                for (int i = 0; i < expresion.Length; ++i) {
                    if (Char.IsDigit(expresion[i])) {
                        number += expresion[i];
                    }
                    else {
                        switch (expresion[i]) {
                            case '+':
                                result = Calculator.Add(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                                break;
                            case '-':
                                result = Calculator.Minus(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                                break;
                            case '*':
                                result = Calculator.Multiplication(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                                break;
                            case '/':
                                result = Calculator.Divine(Convert.ToInt32(number), Convert.ToInt32(expresion.Substring(i + 1)));
                                break;
                        }
                    }

                }
            }
            catch (Exception e) {
                printer.WriteLine(e.Message);
            }

            printer.WriteLine(result.ToString());
        }

        static int Add(int first, int second) => first + second;
        static int Minus(int first, int second) => first - second;
        static double Multiplication(int first, int second) => first * second;
        static double Divine(int first, int second) => first / second;
    }
}
