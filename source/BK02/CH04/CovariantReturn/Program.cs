using System;

namespace CovariantReturn
{
    public abstract record Number
    { public int Value { get; set; } }

    public abstract record BadgeNumber
    { public virtual Number Id { get; } }

    public record EmployeeID : Number
    { public string FullName { get; set; } }

    public record ThisPerson : BadgeNumber
    {
        public ThisPerson(int Identifier, string Name)
        {
            Id = new EmployeeID
            {
                FullName = Name,
                Value = Identifier
            };
        }

        public override Number Id { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Josh = new ThisPerson(22, "Josh");
            Console.WriteLine(Josh);
            Console.WriteLine(Josh.GetType());

            BadgeNumber ThisNumber = Josh;
            Console.WriteLine(ThisNumber);
            Console.WriteLine(ThisNumber.GetType());
        }
    }
}