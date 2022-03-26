using System;
using System.Linq;

namespace SortInterface
{
    // IDisplayable -– Any object that implements the Display() method
    interface IDisplayable
    {
        // Return a description of yourself.
        string Display();
    }

    class Student : IComparable<Student>, IDisplayable
    {
        public Student(string name, double grade)
        { Name = name; Grade = grade; }
        public string Name { get; private set; }
        public double Grade { get; private set; }

        public string Display()
        {
            string padName = Name.PadRight(9);
            return $"{padName}: {Grade:N0}";
        }

        // Implement the IComparable<T> interface:
        // CompareTo -- Compare another object (in this case, Student objects) 
        //   and decide which one comes after the other in the sorted array.
        public int CompareTo(Student rightStudent)
        {
            // Compare the current Student (call her 'left') against the other
            // student (call her 'right').
            Student leftStudent = this;

            // Generate a -1, 0 or 1 based on the Sort criteria (the student's
            // grade). You could use class Double’s CompareTo() method instead).
            if (rightStudent.Grade < leftStudent.Grade)
            {
                Console.WriteLine($"{rightStudent.Name} < {leftStudent.Name}");
                return -1;
            }

            if (rightStudent.Grade > leftStudent.Grade)
            {
                Console.WriteLine($"{rightStudent.Name} > {leftStudent.Name}");
                return 1;
            }

            Console.WriteLine($"{rightStudent.Name} = {leftStudent.Name}");
            return 0;
        }

        // CreateStudentList - To save space here, just create
        // a fixed list of students.
        static string[] names = { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
        static double[] grades = { 0, 85, 50, 100, 30 };

        public static Student[] CreateStudentList()
        {
            Student[] students = new Student[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                students[i] = new Student(names[i], grades[i]);
            }
            return students;
        }
    }

    class Program
    {
        // DisplayArray -– Display an array of objects that implement
        //   the IDisplayable interface.
        public static void DisplayArray(IDisplayable[] displayables)
        {
            foreach (IDisplayable disp in displayables)
                Console.WriteLine($"{disp.Display()}");
        }

        static void Main(string[] args)
        {
            // Sort students by grade...
            Console.WriteLine("Using Array.Sort() to sort.");

            // Get an unsorted array of students.
            Student[] students = Student.CreateStudentList();

            // Use the IComparable interface to sort the array.
            Array.Sort(students);

            // Now the IDisplayable interface to display the results.
            DisplayArray(students);

            // Use Language Integrated Query (LINQ) instead.
            Console.WriteLine("\r\nUsing LINQ to sort.");
            Student[] students2 = Student.CreateStudentList();
            students2 = students2.OrderBy(C => C).ToArray();
            DisplayArray(students2);

            Console.Read();
        }
    }
}
