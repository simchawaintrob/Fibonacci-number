using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Fibonacci
    {
        public double CalculateFibonacci(int index)
        {
            double a = 0, b = 1, c = 0;

            if (index == 0)
                return a;
            if (index == 1)
                return b;


            for (int i = 2; i <= index; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        public double CalculateFibonacciRecursive(int index)
        {
            if (index == 0)
                return 0;
            if (index == 1)
                return 1;

            return CalculateFibonacciRecursive(index - 1) + CalculateFibonacciRecursive(index - 2);
        }
    }
}
