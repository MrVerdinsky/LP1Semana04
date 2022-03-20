using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Main method that runs the program
        /// </summary>
        /// <param name="args">Arguments passed when running
        /// the program</param>
        static void Main(string[] args)
        {
            CountToN(5);
            CountToN(20);
            CountTo10();
        }

        /// <summary>
        /// Method used to count to 10 using the CountToN
        /// method
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);
        }
            
        /// <summary>
        /// Method used to count to N number using the given
        /// value
        /// </summary>
        /// <param name="n">Value to be count to</param>
        private static void CountToN(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
