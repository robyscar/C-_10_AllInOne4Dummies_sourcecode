using System;

namespace UseConstructor
{
    internal class MyObject
    {
        internal int n;
        internal MyObject nextObject;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // First create an object.
            MyObject localObject = new MyObject();
            Console.WriteLine("localObject.n is {0}", localObject.n);

            if (localObject.nextObject == null)
            {
                Console.WriteLine("localObject.nextObject is null");
            }
            Console.Read();
        }
    }
}
