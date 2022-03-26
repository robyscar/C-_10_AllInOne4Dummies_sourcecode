using System;

namespace DemonstrateCustomConstructor
{
    // MyObject -- Create a class with a noisy custom constructor
    //    and an internal data object.
    public class MyObject
    {
        // This data member is a property of the class (it’s static).
        private static MyOtherObject _staticObj = new MyOtherObject();

        // This data member is a property of each instance.
        private MyOtherObject _dynamicObj;

        // Constructor (a real chatterbox)
        public MyObject()
        {
            Console.WriteLine("MyObject constructor starting");
            Console.WriteLine("(Static data member constructed before " +
                              "this constructor)");
            Console.WriteLine("Now create nonstatic data member dynamically:");
            _dynamicObj = new MyOtherObject();
            Console.WriteLine("MyObject constructor ending");
        }
    }

    // MyOtherObject -- This class also has a noisy constructor but
    //    no internal members.
    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("MyOtherObject constructing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main() starting");
            Console.WriteLine("Creating a local MyObject in Main():");
            MyObject localObject = new MyObject();
            Console.Read();
        }
    }
}
