using System;

namespace UseTuples
{
    class Program
    {
        private static Tuple<string, int> getTuple()
        {
            // Return a single value using the tuple.
            return new Tuple<string, int>("Hello", 123);
        }

        static void Main(string[] args)
        {
            // Obtain a single entry tuple.
            Console.WriteLine(
                getTuple().Item1 + " " + getTuple().Item2);
            Console.Read();
        }
    }
}
