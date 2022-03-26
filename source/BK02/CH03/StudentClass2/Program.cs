using System;

namespace StudentClass
{
    internal class Student
    {
        private string _name = "";
        private static int _numStudents = 1;

        internal string Name
        { 
            get => _name;
            set
            {
                if (value.Length > 1)
                    _name = value;
                else
                    throw new ArgumentException("Blank names not allowed!", 
                        "Name");
            }
        }

        internal static void OutputName(Student student)
        {
            Console.WriteLine($"Student's name is {student.Name}.");
        }

        public override string ToString()
        {
            // Output current student's name.
            return $"Student's name is {Name}.";
        }

        internal static int NumStudents { get => _numStudents; }

        internal static void SetNumStudents(int NumStudents)
        {
            if (NumStudents > 0)
                _numStudents = NumStudents;
            else
                throw new ArgumentOutOfRangeException(
                    "Value must be greater than 0", "NumStudents");
        }

        internal static void OutputNumStudents()
        {
            Console.WriteLine($"The number of students is: {_numStudents}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            // Set the number of students.
            try
            {
                Student.SetNumStudents(2);

                // Display the number of students.
                Student.OutputNumStudents();
                Console.WriteLine($"The Number of Students is: {Student.NumStudents}.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Try to supply a bad name.
            Console.WriteLine("\r\nTrying a bad value:");
            try
            {
                student.Name = "";
                Student.OutputName(student);
                Console.WriteLine(student.ToString());
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
                student.Name = "Sally";
                Student.OutputName(student);
                Console.WriteLine(student.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Sent {e.ParamName} \"\" value.");
            }
            Console.Read();
        }
    }
}
