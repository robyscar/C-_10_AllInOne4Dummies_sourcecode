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
                + $" whose value is {d1} and\r\n {s2}"
                + $" whose value is {d2} is {average}.\r\n");
        }

        private static void AverageAndDisplay(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine($"The average of {d1} and {d2}"
                            + $" is {average}.");
        }

        static void Main(string[] args)
        {
            // Access the first version of the method.
            AverageAndDisplay("my GPA", 3.5, "your GPA", 4.0);

            // Access the second version of the method.
            AverageAndDisplay(3.5, 4.0);
            Console.Read();
        }
    }
}
