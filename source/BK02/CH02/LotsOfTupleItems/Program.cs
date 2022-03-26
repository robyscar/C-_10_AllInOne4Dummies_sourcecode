using System;

namespace LotsOfTupleItems
{
    class Program
    {
        static Tuple<string, int, bool>[] getTuple()
        {
            // Create a new tuple.
            Tuple<string, int, bool>[] aTuple =
            {
                new Tuple<string, int, bool>("One", 1, true),
                new Tuple<string, int, bool>("Two", 2, false),
                new Tuple<string, int, bool>("Three", 3, true)
            };

            // Return a list of values using the tuple.
            return aTuple;
        }

        static void Main(string[] args)
        {
            // Obtain a multiple entry tuple.
            Tuple<string, int, bool>[] myTuple = getTuple();

            // Output the values.
            foreach (var Item in myTuple)
            {
                Console.WriteLine($"{Item.Item1}\t{Item.Item2}\t{Item.Item3}");
            }

            var myTuple2 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            Console.WriteLine(myTuple2.Item11);
            foreach (var Item in myTuple2.ToString().Split(','))
            {
                Console.WriteLine(Item);
            }
            Console.Read();
        }
    }
}
