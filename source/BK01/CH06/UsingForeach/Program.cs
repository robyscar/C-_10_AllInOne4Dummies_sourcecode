using System;

namespace UsingForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = { "Hello", "Goodbye", "Today", "Tomorrow" };

            int sum = 0;
            foreach (string thisString in myStrings)
            {
                Console.WriteLine($"The current string is: {thisString}.");
                Console.WriteLine($"It's {thisString.Length} characters long.");
                sum += thisString.Length;
            }

            double average = (double)sum / myStrings.Length;
            Console.WriteLine($"The average character length is: {average}.");
            Console.ReadLine();
        }
    }
}
