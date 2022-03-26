using System;

namespace MethodsWithDefaultArguments
{
    class Program
    {
        static private string DisplayRoundedDecimal(
            decimal value = 0,
            int numberOfSignificantDigits = 2)
        {
            // First round off the number to the specified number
            // of significant digits.
            decimal roundedValue = decimal.Round(
                value, numberOfSignificantDigits);

            // Convert that to a string.
            string s = Convert.ToString(roundedValue);
            return s;
        }

        static void Main(string[] args)
        {
            // Don't supply any values.
            Console.WriteLine(DisplayRoundedDecimal());

            // Supply just the first value.
            Console.WriteLine(DisplayRoundedDecimal(12.345678M));

            // Provide both values.
            Console.WriteLine(DisplayRoundedDecimal(12.345678M, 3));
            Console.ReadLine();
        }
    }
}
