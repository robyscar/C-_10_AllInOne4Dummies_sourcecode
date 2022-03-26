using System;
using System.Collections.Generic;

namespace CollectionMoveNext
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Colors = new List<string> {
                "Red", "Yellow", "Green", "Blue" };

            Console.WriteLine("Using a delegate.");
            Colors.ForEach(delegate (string value)
            {
                Console.WriteLine(value);
            });

            Console.WriteLine("\r\nUsing a foreach.");
            foreach (string col in Colors)
                Console.WriteLine(col);

            Console.WriteLine("\r\nUsing an enumerator.");
            var colEnum = Colors.GetEnumerator();
            while (colEnum.MoveNext())
                Console.WriteLine(colEnum.Current);
            Console.ReadLine();
        }
    }
}
