using System;

namespace SwitchExpression
{
    class Program
    {
        public enum Greetings
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public static string GreetString(Greetings value) => value switch
        {
            Greetings.Morning => "Good Morning!",
            Greetings.Afternoon => "Good Afternoon!",
            Greetings.Evening => "See you tomorrow!",
            Greetings.Night => "Are you still here?",

            // Added solely to cover all cases.
            _ => "Not sure what time it is!"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(GreetString(Greetings.Morning));
            Console.WriteLine(GreetString(Greetings.Afternoon));
            Console.WriteLine(GreetString(Greetings.Evening));
            Console.WriteLine(GreetString(Greetings.Night));
            Console.ReadLine();
        }
    }
}
