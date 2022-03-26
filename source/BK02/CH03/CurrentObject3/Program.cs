using System;

namespace CurrentObject
{
    internal class Student
    {
        // The name information to describe a student
        private string firstName;
        private string lastName;

        // SetName -- Save name information.
        internal void SetName(string FirstName, string LastName)
        {
            this.SetFirstName(FirstName);
            this.SetLastName(LastName);
        }

        private void SetFirstName(string FirstName)
        {
            this.firstName = FirstName;
        }

        private void SetLastName(string LastName)
        {
            this.lastName = LastName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.SetName("Joseph", "Smith");

            Student student2 = new Student();
            student2.SetName("John", "Davis");

            // Show that the students are separate.
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.ReadLine();
        }
    }
}
