using System;

namespace CallByReference
{
    class Program
    {
        private static void Average(
            ref double Result,
            double Input1 = 1.0,
            double Input2 = 2.0)
        {
            Result = (Input1 + Input2) / 2;
        }

        static void Main(string[] args)
        {
            // Initialize Result and show it.
            double Result = 0;
            Console.WriteLine(Result);

            // Make the call.
            Average(ref Result, 4.0, 3.0);

            // Show the change.
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
