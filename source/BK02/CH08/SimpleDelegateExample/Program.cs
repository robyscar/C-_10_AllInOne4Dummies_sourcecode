using System;

namespace SimpleDelegateExample
{
    class Program
    {
        // Inside class or inside namespace
        delegate int MyDelType(string name);

        static void Main(string[] args)
        {
            // Create a delegate instance pointing to the CallBackMethod below.
            // Note that the callback method is static, so you prefix the name
            // with the class name, Program.
            MyDelType del = new MyDelType(Program.CallBackMethod);

            // Call a method that will invoke the delegate.
            UseTheDel(del, "hello");
            Console.Read();
        }

        // CallBackMethod -- A method that conforms to the MyDelType
        //    delegate signature (takes a string, returns an int).
        //    The delegate will call this method.
        public static int CallBackMethod(string stringPassed)
        {
            // Leave tracks to show you were here.
            // What's written here? stringPassed.
            Console.WriteLine($"CallBackMethod writes: {stringPassed}");

            // Return an int.
            return stringPassed.Length;  // Delegate requires an int return.
        }

        // UseTheDel -- A “workhorse” method that takes a MyDelType delegate
        //    argument and invokes the delegate. arg is a string to pass
        //    to the delegate invocation.
        private static void UseTheDel(MyDelType del, string arg)
        {
            if (del == null) return; // Don't invoke a null delegate!

            // Here's where you invoke the delegate.
            // What's written here? A number representing the length of arg.
            Console.WriteLine($"UseTheDel writes {del(arg)}");
        }
    }
}
