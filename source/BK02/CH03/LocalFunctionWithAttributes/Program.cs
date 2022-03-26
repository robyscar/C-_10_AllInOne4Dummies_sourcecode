using System;
using System.Diagnostics;

namespace LocalFunctionWithAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a debug local function
            [Obsolete]
            [Conditional("DEBUG")]
            static void DebugInfo(int x, int y)
            {
                Console.WriteLine($"Input x: {x}\r\nInput y: {y}");
            }

            static int Sum(int x, int y) { return x + y; }

            // Use the local function to output some sums.
            Console.WriteLine(Sum(1, 2));
            DebugInfo(1, 2);
            Console.WriteLine(Sum(5, 6));
            DebugInfo(5, 6);
            Console.Read();
        }
    }
}
