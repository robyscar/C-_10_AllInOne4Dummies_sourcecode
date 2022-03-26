using System;

namespace BuildASentence3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be "
                           + "added to a sentence until you "
                           + "enter EXIT or QUIT");

            // Ask the user for input; continue concatenating
            // the phrases input until the user enters exit or
            // quit (start with an empty sentence).
            string sentence = "";

            for(; ; )
            {
                // Get the next line.
                Console.WriteLine("Enter a string ");
                string line = Console.ReadLine();

                // Use a switch to end the program.
                switch (line)
                {
                    case "EXIT":
                    case "exit":
                    case "QUIT":
                    case "quit":
                        return;
                }

                // Otherwise, add it to the sentence.
                sentence = String.Concat(sentence, line);

                // Let the user know how she's doing.
                Console.WriteLine("\nyou've entered: " + sentence);
            }

            Console.WriteLine("\ntotal sentence:\n" + sentence);
            Console.Read();
        }
    }
}
