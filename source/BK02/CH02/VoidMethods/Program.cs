using System;

namespace VoidMethods
{
    class Program
    {
        private static void DisplayRatio(double numerator,
                                        double denominator)
        {
            // If the denominator is zero . . .
            if (denominator == 0.0)
            {
                //  . . .output an error message and . . .
                Console.WriteLine("The denominator of a ratio cannot be 0");

                //  . . .return to the caller.
                return;  // An early return due to the error
            }

            // This code is executed only if denominator is nonzero.
            double ratio = numerator / denominator;
            Console.WriteLine($"The ratio of {numerator}" + 
                $" over {denominator} is {ratio}.");
        }  // If the denominator isn’t zero, the method exits here.

        static void Main(string[] args)
        {
            // Call DisplayRatio() with a bad denominator.
            DisplayRatio(2, 0);

            // Call it with good values.
            DisplayRatio(2, 4);
            Console.ReadLine();
        }
    }
}
