using System;
using System.IO;

namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the name of a file to process. If the user doesn't
            // provide one, exit with an error code of -1.
            Console.Write("Enter the name of a text file to read: ");
            String filename = Console.ReadLine();
            if (filename.Length == 0)
            {
                Console.WriteLine("No filename provided, exiting.");
                Environment.Exit(-1);
            }

            // Verify that the file actually exists. If not, then exit
            // with a -2 error code.
            if (!File.Exists(filename))
            {
                Console.WriteLine("The File doesn't exit!");
                Console.ReadLine();
                Environment.Exit(-2);
            }

            // Open the file for processing by creaing a FileStream and
            // a StreamReader with a using statement.
            using (StreamReader sr = new StreamReader(filename))
            {
                Console.WriteLine("\nContents of File:");

                // Proces the file one line at a time.
                while(!sr.EndOfStream)
                {
                    String input = sr.ReadLine();
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
        }
    }
}
