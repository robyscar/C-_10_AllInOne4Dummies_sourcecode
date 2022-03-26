using System;

namespace RemoveWhiteSpace2
{
    class Program
    {
        // RemoveWhiteSpace -- The RemoveSpecialChars method removes every
        //    occurrence of the specified characters from the string.
        public static string RemoveSpecialChars(string input, char[] targets)
        {
            // Split the input string up using the target
            // characters as the delimiters.
            string[] subStrings = input.Split(targets);

            // output will contain the eventual output information.
            string output = "";

            // Loop through the substrings originating from the split.
            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }
            return output;
        }

        static void Main(string[] args)
        {
            // Define the white space characters.
            char[] whiteSpace = { ' ', '\n', '\t' };

            // Start with a string embedded with whitespace.
            string s = " this is a\nstring"; // Contains spaces & newline.
            Console.WriteLine("before:" + s);

            // Output the string with the whitespace missing.
            Console.Write("after:" + RemoveSpecialChars(s, whiteSpace));
            Console.Read();
        }
    }
}
