using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalcService
    {
        Multiply m = new Multiply();
        public void CalculateNumbers(int x, int y)
        {
            m.Mult(x, y);
        }
    }
}
