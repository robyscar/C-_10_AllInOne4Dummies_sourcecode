using System;
using Parts;

namespace Parts
{
    public partial class DoStuff
    {
        internal int TheValue
        { get; private set; }

        public DoStuff()
        {
            TheValue = 0;
        }

        public override string ToString()
        {
            return $"The value is: {TheValue}.";
        }

        public partial void DoDivide(int value);
    }
}

namespace PartialParts
{
    class PartOne
    {
        static void Main(string[] args)
        {
            DoStuff thisStuff = new DoStuff();

            try
            {
                thisStuff.DoAdd(-1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                thisStuff.DoAdd(5);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                thisStuff.DoSubtract(1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                thisStuff.DoDivide(2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"{thisStuff.ToString()}");
            Console.ReadLine();
        }
    }
}
