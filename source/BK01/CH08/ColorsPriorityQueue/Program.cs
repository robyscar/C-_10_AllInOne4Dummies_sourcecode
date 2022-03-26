using System;
using System.Collections.Generic;

namespace ColorsPriorityQueue
{
    class Program
    {
        // Define the preference levels.
        enum Preference
        {
            First, Second, Third
        }

        static void Main(string[] args)
        {
            // Create a priority queue.
            PriorityQueue<string, Preference> colors = 
                new PriorityQueue<string, Preference>();

            // Add some colors and their preference to it.
            colors.Enqueue("Red", Preference.First);
            colors.Enqueue("Orange", Preference.Third);
            colors.Enqueue("Yellow", Preference.First);
            colors.Enqueue("Green", Preference.Second);
            colors.Enqueue("Blue", Preference.Second);
            colors.Enqueue("Purple", Preference.First);
            colors.Enqueue("White", Preference.Third);
            colors.Enqueue("Black", Preference.Third);

            // Display the list by priority on screen.
            while (colors.TryDequeue(out var Color, out var Pref))
                Console.WriteLine($"{Color} is {Pref} preference.");
        }
    }
}
