using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nArgs = args.Length;
            int value;
            if (nArgs == 0)
            {
                Console.WriteLine("Insert place of Fibonacci Value: ");
                value = int.Parse(Console.ReadLine());
            }
            else
            {
                value = nArgs;
            }

            Console.WriteLine(Fibonacci(value));
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
