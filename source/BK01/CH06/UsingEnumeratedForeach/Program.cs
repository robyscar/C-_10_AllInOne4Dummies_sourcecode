using System;
using System.Collections.Generic;

namespace UsingEnumeratedForeach
{
    public static class Extensions
    {
        public static IEnumerator<T> GetEnumerator<T>(this 
            IEnumerator<T> enumerator) => enumerator;
    }

    class Program
    {
        static void Main(string[] args)
        {
            String[] myStrings = { "Hello", "Goodbye", "Today", "Tomorrow" };
            IEnumerator<string> stringEnum = (IEnumerator<string>)new 
                List<string>(myStrings).GetEnumerator();

            while ((string)stringEnum.Current != "Hello")
                stringEnum.MoveNext();

            int sum = 0;
            int count = 0;
            foreach (var thisString in stringEnum)
            {
                Console.WriteLine($"The current string is: {thisString}.");
                Console.WriteLine($"It's {thisString.Length} characters long.");
                sum += thisString.Length;
                count++;
            }

            double average = (double)sum / count;
            Console.WriteLine($"The average character length is: {average}.");
            Console.ReadLine();

        }
    }
}
