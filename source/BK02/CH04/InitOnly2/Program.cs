using System;

namespace InitOnly
{
    internal class CreditMember
    {
        internal int Id { get; init; }
        internal string Name { get; set; }
        internal decimal Limit { get; set; }

        public override string ToString()
        {
            return $"{Name}, member ID {Id}, has a " +
                $"limit of {Limit:C}";
        }

        internal protected CreditMember(int MemberId)
        {
            Id = MemberId;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreditMember Sam = new CreditMember(1);
            Sam.Name = "Sam Jones";
            Sam.Limit = 5000;

            Console.WriteLine(Sam.ToString());
            Console.ReadLine();
        }
    }
}
