using System;

namespace BasicRecord
{
    class Program
    {
        public record Person
        {
            public string First { get; set; }
            public string? Middle { get; set; }
            public string Last { get; set; }
            public int? Age { get; set; }

            public override string ToString()
            {
                if (Age.HasValue)
                    return $"{Last}, {First} {Middle}\r\nAge: {Age}";
                else
                    return $"{Last}, {First} {Middle}\r\nAge Withheld";
            }
        }

        public record Person2(string First, string Middle, string Last, int? Age)
        {
            public override string ToString()
            {
                if (Age.HasValue)
                    return $"{Last}, {First} {Middle}\r\nAge: {Age}";
                else
                    return $"{Last}, {First} {Middle}\r\nAge Withheld";
            }
        }

        static void Main(string[] args)
        {
            Person ThisPerson = new Person()
            {
                First = "Amanda",
                Middle = null,
                Last = "Langley",
                Age = null
            };

            Console.WriteLine(ThisPerson.ToString());

            Person2 NextPerson = new("Andy", "X", "Rustic", 42);
            Console.WriteLine(NextPerson.ToString());

            Person2 ThirdPerson = new("Andy", "X", "Rustic", 42);
            Console.WriteLine($"NextPerson == ThirdPerson: " +
                $"{NextPerson == ThirdPerson}");
            Console.WriteLine($"ReferenceEquals(NextPerson, ThirdPerson): " +
                $"{ReferenceEquals(NextPerson, ThirdPerson)}");

            Person2 FourthPerson = ThirdPerson with { Age = null };
            Console.WriteLine(FourthPerson);
            Console.ReadLine();
        }
    }
}
