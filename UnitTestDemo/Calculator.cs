using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Min(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            if(b == 0)
            {
                throw new ArgumentException("2nd integer cannot be 0");
            }
            return a / b;
        }
    }
}
