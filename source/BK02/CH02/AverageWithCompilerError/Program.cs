using System;

namespace AverageAndDisplay
{
    class Program
    {
        // AverageAndDisplay -- Average two numbers with their
        //    labels and display the results.
        private static void AverageAndDisplay(string s1, double d1,
                                             string s2, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine($"The average of {s1}"
                + $" whose value is {d1} and {s2}"
                + $" whose value is {d2} is {average}.");
        }

        static void Main(string[] args)
        {
            // Access the member method.
            AverageAndDisplay("grade 1", "grade 2", 3.5, 4.0);
            Console.Read();
        }
    }
}
