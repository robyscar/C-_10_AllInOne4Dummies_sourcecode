using System;

namespace IsAllDigits
{
    class Program
    {
        // IsAllDigits -- Return true if all characters
        //   in the string are digits.
        public static bool IsAllDigits(string raw)
        {
            // First get rid of any benign characters at either end;
            // if there's nothing left, you don't have a number.
            string s = raw.Trim();  // Ignore white space on either side.
            if (s.Length == 0) return false;

            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // Minus signs are OK, so go to the next character.
                if (s[index] == '-' && index == 0) continue;

                // A nondigit indicates that the string probably isn’t a number.
                if (Char.IsDigit(s[index]) == false) return false;
            }

            // No nondigits found; it's probably okay.
            return true;
        }

        static void Main(string[] args)
        {
            // Input a string from the keyboard.
            Console.WriteLine("Enter an integer number");
            string s = Console.ReadLine();

            // First check to see if this could be a number.
            if (!IsAllDigits(s)) // Call the special method.
            {
                Console.WriteLine("Hey! That isn't a number");
            }
            else
            {
                // Convert the string into an integer.
                int n = Int32.Parse(s);

                // Now write out the number times 2.
                Console.WriteLine("2 * " + n + " = " + (2 * n));
            }

            Console.Read();
        }
    }
}
