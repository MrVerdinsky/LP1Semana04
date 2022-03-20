using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(8));
        }

        private static int Fibonacci(int n)
        {
            int x;
            if (n <= 2)
            {
                x = 1;
            }
            else
            {
                x = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return x;
        }
    }
}
