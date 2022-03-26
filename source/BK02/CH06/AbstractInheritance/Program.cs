using System;

namespace AbstractInheritance
{
    // AbstractBaseClass -- Create an abstract base class with nothing
    //    but an Output() method. You can also say "public abstract."
    abstract public class AbstractBaseClass
    {
        // Output -- Abstract method that outputs a string
        abstract public void Output(string outputString);
    }

    // SubClass1 -- One concrete implementation of AbstractBaseClass
    public class SubClass1 : AbstractBaseClass
    {
        override public void Output(string source) // Or “public override”
        {
            string s = source.ToUpper();
            Console.WriteLine($"Call to SubClass1.Output() from within {s}");
        }
    }

    // SubClass2 -- Another concrete implementation of AbstractBaseClass
    public class SubClass2 : AbstractBaseClass
    {
        public override void Output(string source)  // Or “override public”
        {
            string s = source.ToLower();
            Console.WriteLine($"Call to SubClass2.Output() from within {s}");
        }
    }

    class Program
    {
        public static void Test(AbstractBaseClass ba)
        {
            ba.Output("Test");
        }

        static void Main(string[] args)
        {
            // You can't create an AbstractBaseClass object because it's
            // abstract. C# generates a compile-time error if you
            // uncomment the following line.
            // AbstractBaseClass ba = new AbstractBaseClass();

            // Now repeat the experiment with Subclass1.
            Console.WriteLine("\ncreating a SubClass1 object");
            SubClass1 sc1 = new SubClass1();
            Test(sc1);

            // And, finally, a Subclass2 object
            Console.WriteLine("\ncreating a SubClass2 object");
            SubClass2 sc2 = new SubClass2();
            Test(sc2);
            Console.Read();
        }
    }
}
