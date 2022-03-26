using System;

namespace RefStruct
{
    public ref struct FullName
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }

        public override string ToString()
        {
            return $"Name: {First} {Middle} {Last}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullName ThisName = new FullName
            {
                First = "Sam",
                Middle = "L",
                Last = "Johnson"
            };

            Console.WriteLine(ThisName.ToString());
            Console.ReadLine();
        }
    }
}
