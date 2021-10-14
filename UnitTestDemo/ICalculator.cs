using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Min(int a, int b);
        int Mul(int a, int b);
        int Div(int a, int b);
    }
}
