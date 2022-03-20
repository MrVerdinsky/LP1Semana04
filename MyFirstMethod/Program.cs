using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToN(5);
            CountToN(20);
            CountTo10(10);
        }

        private static void CountTo10(int n)
        {
            CountToN(n);
        }
            

        private static void CountToN(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
