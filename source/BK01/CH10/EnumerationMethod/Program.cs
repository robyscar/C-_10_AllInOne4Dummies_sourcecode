using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationMethod
{
    public enum Colors { Red, Orange, Yellow, Green, Blue, Purple};

    public static class Extensions
    {
        public static string GetNameValue(this Colors color)
        {
            return $"{color} is {color.GetTypeCode()} = {((long)color)}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display each of the colors in turn.
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(color.GetNameValue());
        }
    }
}
