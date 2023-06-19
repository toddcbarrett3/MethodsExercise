using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Method1
    {
        public static void Add(int num1, int num2)
        {
        int result = num1 + num2;
        Console.WriteLine(result);
        }
        public static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        public static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);

        }
        public static void Divide(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}


