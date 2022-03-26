using System;

namespace PassObject
{
    internal class Student
    {
        internal string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            // Set the name by accessing it directly.
            Console.WriteLine("The first time:");
            student.Name = "Madeleine";
            OutputName(student);

            // Try to supply a bad name.
            Console.WriteLine("\r\nTrying a bad value:");
            try
            {
                SetName(student, "");
                OutputName(student);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Sent {e.ParamName} \"\" value.");
            }

            // Change the name using a method.
            Console.WriteLine("\r\nAfter being modified:");
            try
            {
                SetName(student, "Willa");
                OutputName(student);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Sent {e.ParamName} \"\" value.");
            }
            Console.Read();
        }

        // OutputName -- Output the student's name.
        private static void OutputName(Student student)
        {
            // Output current student's name.
            Console.WriteLine($"Student's name is {student.Name}.");
        }

        // SetName -- Modify the student object's name.
        private static void SetName(Student student, string name)
        {
            if (name.Length > 1)
                student.Name = name;
            else
                throw new ArgumentException("Blank names not allowed!", "name");
        }
    }
}
