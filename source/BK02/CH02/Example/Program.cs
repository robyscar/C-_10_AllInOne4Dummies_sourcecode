using System;

namespace Example
{
    class Example
    {
        public int anInt;                  // Instance
        public static int staticInt;       // Static

        public void InstanceMethod()       // Instance
            {
                Console.WriteLine("this is an instance method");
            }

            public static void ClassMethod()   // Static
            {
                Console.WriteLine("this is a static method");
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example fieldInstance = new Example();  // Create an instance of class Example.
            fieldInstance.anInt = 1;                // Initialize instance member.
            Example.staticInt = 2;                  // Initialize class member.

            // These line will compile.
            Example thisInstance = new Example(); // Create an instance.
            thisInstance.InstanceMethod();        // Invoke the instance method.
            Example.ClassMethod();                // Invoke the class method.

            // The following lines won’t compile.
            //thisInstance.ClassMethod();           // No class method access via instance.
            //Example.InstanceMethod();             // No instance method access via a class.

            Console.ReadLine();
        }
    }
}
