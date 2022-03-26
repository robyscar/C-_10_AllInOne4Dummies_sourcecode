using System;
using System.Linq;

namespace ColorList
{
    public struct ColorList
    {
        private string[] names;

        public string this[int i]
        { get => names[i]; set => names[i] = value; }

        public void Add(string ColorName)
        {
            if (names == null)
            {
                names = new string[1];
                names[0] = ColorName;
            }
            else
            {
                names = names.Concat<string>(
                    new string[] { ColorName }).ToArray();
            }
        }

        public int Length
        { get => names.Length; }

        public static ColorList operator +(ColorList First, ColorList Second)
        {
            ColorList Output = new ColorList();

            for (int i = 0; i < First.Length; i++)
                Output.Add(First[i]);

            for (int i = 0; i < Second.Length; i++)
                Output.Add(Second[i]);

            return Output;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a color list.
            ColorList myList = new ColorList();

            // Fill it with values.
            myList.Add("Yellow");
            myList.Add("Blue");

            // Display each of the elements in turn.
            for (int i = 0; i < myList.Length; i++)
                Console.WriteLine("Color = " + myList[i]);

            // Create and fill a second color list.
            ColorList myList2 = new ColorList();
            myList2.Add("Red");
            myList2.Add("Purple");

            // Add the first list to the second.
            ColorList myList3 = myList + myList2;

            // Display each of the elements in turn.
            Console.WriteLine("\r\nCombined Color Lists\r\n");
            for (int i = 0; i < myList3.Length; i++)
                Console.WriteLine("myList3 Color = " + myList3[i]);

            Console.ReadLine();
        }
    }
}
