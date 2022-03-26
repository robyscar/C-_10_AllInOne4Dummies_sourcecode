using System;

namespace FactorialException
{
    class Program
    {
        // MyMathFunctions -- A collection of mathematical functions
        //    we created (it's not much to look at yet)
        public class MyMathFunctions
        {
            /// <summary>
            ///   public static int Factorial(int value)
            ///   <para>Return the factorial of the provided value.</para>
            ///   <example>
            ///     This shows a basic call.
            ///     <code>
            ///       input = 5;
            ///       int output = Factorial(input);
            ///     </code>
            ///   </example>
            /// </summary>
            /// <param name="value">The x! to find.</param>
            /// <returns>Factorial value as int.</returns>
            /// <exception cref="ArgumentOutOfRangeException">
            ///   The value must be greater than 0.
            /// </exception>
            /// <exception cref="OverflowException">
            ///   The x! is too large to compute.
            /// </exception>
            public static int Factorial(int value)
            {
                // Don't allow negative numbers.
                if (value < 0)
                {
                    // Report negative argument.
                    string s = String.Format(
                         "Illegal negative argument to Factorial {0}", value);

                    throw new ArgumentOutOfRangeException(s);
                }

                // Check specifically for 0.
                if (value == 0)
                    return 1;

                // Begin with an "accumulator" of 1.
                int factorial = 1;

                // Loop from value down to 1, each time multiplying
                // the previous accumulator value by the result.
                do
                {
                    factorial *= value;

                    // Check for an overflow.
                    if (factorial == 0)
                    {
                        string s = String.Format(
                             "Input Number {0} Too Large!", value);
                        throw new OverflowException(s);
                     }
                } while (--value > 1);

                // Return the accumulated value.
                return factorial;
            }
        }

        static void Main(string[] args)
        {
            string Input = string.Empty;

            while (Input.ToLower() != "quit")
            {
                // Get input from the user and check for Quit.
                Console.WriteLine("Enter a positive number or Quit: ");
                Input = Console.ReadLine();
                if (Input.ToLower() == "quit")
                    continue;

                // Make sure the input is an integer number.
                int Value = 0;
                if (!Int32.TryParse(Input, out Value))
                {
                    Console.WriteLine("Please enter an integer number or Quit!");
                    continue;
                }

                // Here’s the exception handler.
                int Factorial = 0;
                try
                {
                    // Calculate the factorial of the number.
                    Factorial = MyMathFunctions.Factorial(Value);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    // Tell the user about the problem.
                    Console.WriteLine("You must enter a positive number!");

                    // Fix the problem by trying again.
                    continue;
                }
                catch (OverflowException e)
                {
                    // Tell the user about the problem.
                    Console.WriteLine("The number supplied is too large!");

                    // Fix the problem by trying again.
                    continue;
                }
                catch (Exception e)
                {
                    // OK, now we have no idea of what's wrong.
                    Console.WriteLine("An unexplainable error has happened!");

                    // Output the error information so someone can learn more.
                    Console.WriteLine(e.ToString());

                    // Exit the application gracefully with an error code.
                    System.Environment.Exit(-1);
                }
                finally
                {
                    Console.WriteLine("Thank you for testing the application!");
                }

                Console.WriteLine($"The factorial of {Value} is {Factorial}.");
            }

            Console.Read();
        }
    }
}
