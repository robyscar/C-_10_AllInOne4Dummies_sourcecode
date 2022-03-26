using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            double MyVar = 123.456;
            Console.WriteLine($"This is the exponential form: {MyVar:E}.");
            Console.WriteLine($"This is the percent form: {MyVar:#.#%}.");
            Console.WriteLine($"This is the zero padded form: {MyVar:0000.0000}.");
        }
    }
}
