using System;

namespace SwitchPattern
{
    class Program
    {
        public static string LetterType(char letter) => letter switch
        {
            >= 'a' and <= 'z' => "lowercase letter",
            >= 'A' and <= 'Z' => "uppercase letter",
            >= '1' and <= '9' => "number",
            >= ' ' and <= '/' or
            >= ':' and <= '@' or
            >= '[' and <= '`' or
            >= '{' and <= '~' => "special character",
            _ => "Unknown letter type"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("a is a " + LetterType('a') + ".");
            Console.WriteLine("B is an " + LetterType('B') + ".");
            Console.WriteLine("3 is a " + LetterType('3') + ".");
            Console.WriteLine("? is a " + LetterType('?') + ".");
            Console.WriteLine("À is an " + LetterType('À') + ".");
            Console.ReadLine();
        }
    }
}
