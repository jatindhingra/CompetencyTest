using System;

namespace FibonacciCheck
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            try
            {
                int n1 = 0, n2 = 1, n3, i, n;
                n = 8;
                Console.WriteLine("Fibonacci series:");
                Console.Write(n1 + " " + n2 + " ");
                for (i = 2; i < n; ++i)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }

                Console.WriteLine(" \n Test Case");
                Console.WriteLine("Enter a number you want to test :");
                int x = Convert.ToInt32(Console.ReadLine());
                TestCases tc = new TestCases();
                Console.WriteLine(tc.isFibonacci(x) ? x + " is a Fibonacci Number" : x + " is a not Fibonacci Number");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
