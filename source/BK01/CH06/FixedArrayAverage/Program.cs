using System;

namespace FixedArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };

            // Accumulate the values in the array into the variable sum.
            double sum = 0;
            for (int i = 0; i < doublesArray.Length; i++)
            {
                sum = sum + doublesArray[i];
            }

            // Now calculate the average.
            double average = sum / doublesArray.Length;
            Console.WriteLine(average);
            Console.Read();
        }
    }
}
