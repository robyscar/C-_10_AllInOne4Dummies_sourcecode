using System;

namespace ActionFuncPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define and execute the action.
            Action<int, int> showIntMath = new Action<int, int>(DisplayAdd);
            showIntMath(1, 2);

            // Define and execute the function.
            Func<int, int, int> doIntMath = new Func<int, int, int>(DoAdd);
            Console.WriteLine($"1 + 2 = {doIntMath(1, 2)}.");

            // Define and execute the predicate.
            Values theseValues = new Values() { value1 = 1, value2 = 2 };
            Predicate<Values> isValue = x => x.value1 + x.value2 == 3;
            Console.WriteLine($"The output is 3? {isValue(theseValues)}");
            Console.ReadLine();
        }

        static void DisplayAdd(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2} = {value1 + value2}.");
        }

        static int DoAdd(int value1, int value2)
        {
            return value1 + value2;
        }

        internal struct Values
        {
            internal int value1;
            internal int value2;
        }
    }
}
