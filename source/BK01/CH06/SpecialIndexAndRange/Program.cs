using System;

namespace SpecialIndexAndRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };

            Console.WriteLine("Standard Index");
            Console.WriteLine(doublesArray[0]);

            Console.WriteLine("\nIndex from the End");
            Console.WriteLine(doublesArray[^1]);

            Console.WriteLine("\nIndex a Range");
            double[] subset = doublesArray[0..3];
            foreach (double value in subset)
            { Console.WriteLine(value); }

            Console.WriteLine("\nIndex a Range from the End");
            subset = doublesArray[^3..^0];
            foreach (double value in subset)
            { Console.WriteLine(value); }
        }
    }
}
