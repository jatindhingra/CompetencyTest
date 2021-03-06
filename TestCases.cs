using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciCheck
{
    class TestCases
    {
        public bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

       
        public bool isFibonacci(int n)
        {
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }
      

    }
}
