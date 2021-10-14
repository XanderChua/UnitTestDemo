using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Program
    {
        public static int addResult, minResult, mulResult, divResult;
        public static ICalculator calc;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer: ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("Enter the second integer: ");
            string integer2 = Console.ReadLine();
            int a = int.Parse(integer1);
            int b = int.Parse(integer2);
            //CallCalculatorMethods(a, b);
            calc = new Calculator();
            CalculatorManagement calculatorManagement = new CalculatorManagement(calc);
            calculatorManagement.CallCalculatorMethods(a, b);
            Console.ReadLine();
        }

        public static void CallCalculatorMethods(int a, int b)
        {                       
            addResult = calc.Add(a, b);
            Console.WriteLine("Add: " + addResult);
            minResult = calc.Min(a, b);
            Console.WriteLine("Min: " + minResult);
            mulResult = calc.Mul(a, b);
            Console.WriteLine("Mul: " + mulResult);
            divResult = calc.Div(a, b);
            Console.WriteLine("Div: " + divResult);
        }
    }
}
