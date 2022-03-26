using System;
using System.Linq;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

namespace ReadOnlyStruct
{
    public readonly struct ReadOnlyData
    {
        // Create properties to hold values.
        public readonly int Value { get; init; }

        // Define a constructor to assign values
        // to the properties.
        public ReadOnlyData(int n)
        {
            Value = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Define some data.
            int[] Data = Enumerable.Range(1, 5).ToArray();

            // Create the read-only structure.
            ReadOnlyData MyReadOnlyData = new ReadOnlyData(10);

            // Perform a task with the structure.
            int Result = 0;
            foreach (int n in Data)
            {
                Result += n + MyReadOnlyData.Value;
                Console.WriteLine(
                    $"n = {n}\tValue = {MyReadOnlyData.Value}\t" +
                    $"Result = {Result}");
            }

            // Use a C# 9.0 construction.
            ReadOnlyData MyReadOnlyData2 = new ReadOnlyData
            {
                Value = 12
            };

            // Perform a task with the second structure.
            Console.WriteLine("\n\rUsing the Second Structure\r\n");
            Result = 0;
            foreach (int n in Data)
            {
                Result += n + MyReadOnlyData2.Value;
                Console.WriteLine(
                    $"n = {n}\tValue = {MyReadOnlyData2.Value}\t" +
                    $"Result = {Result}");
            }

            Console.ReadLine();
        }
    }
}
