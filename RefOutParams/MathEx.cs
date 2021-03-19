using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RefOutParams
{
    static class MathEx
    {
        public const double Fi = 1.618; //(a+b)/a = a / b;
        public const double S = 2.414; //((2*a)+b)/a = a / b;
        public const double K = 0.916;

        public static bool Divide(double firstNumber, double secondNumber, out double result)
        {
            result = firstNumber / secondNumber;
            if (secondNumber == 0 || firstNumber == 0)
            {
                return false;
            }
            return true;
        }
        public static bool Pow(ref double value)
        {
            value = Math.Pow(value, 2);
            return value >= 0;
        }

        public static double Sum(params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}
