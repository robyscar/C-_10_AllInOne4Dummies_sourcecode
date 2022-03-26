using System;

namespace CreateTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Create() method.
            var myTuple = Tuple.Create<string, int>("Hello", 123);
            Console.WriteLine(myTuple.Item1 + "\t" + myTuple.Item2);

            // Use a more direct approach.
            (string, int) t1 = ("Hello", 123);
            Console.WriteLine($"{t1.Item1}\t{t1.Item2}");
            Console.ReadLine();
        }
    }
}
