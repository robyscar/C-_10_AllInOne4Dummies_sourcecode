using System;

namespace BasicLocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a local function
            int Sum(int x, int y) { return x + y; }

            // Use the local function to output some sums.
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(5, 6));
            Console.Read();
        }
    }
}
