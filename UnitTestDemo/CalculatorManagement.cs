using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class CalculatorManagement
    {
        private ICalculator calc;
        public int addResult, minResult, mulResult, divResult;
        public CalculatorManagement(ICalculator calculator)
        {
            calc = calculator;
        }
        public void CallCalculatorMethods(int a, int b)
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
