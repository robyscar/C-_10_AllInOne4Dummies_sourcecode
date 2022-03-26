using System;

namespace CheckFavoriteFood
{
    class Program
    {
        static string Quantity(int burgers) => burgers switch
        {
            <= 2 => "too few",
            > 10 => "too many",
            _ => "an acceptable number of",
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Buying " + Quantity(1) + " burgers.");
            Console.WriteLine("Buying " + Quantity(13) + " burgers.");
            Console.WriteLine("Buying " + Quantity(3) + " burgers.");

            Console.ReadLine();
        }
    }
}
