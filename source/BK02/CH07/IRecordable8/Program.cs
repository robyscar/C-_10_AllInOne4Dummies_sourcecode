using System;

namespace IRecordable8
{
    public interface IRecordable
    {
        // This is a default implementation.
        public string GetName()
        {
            return "Writing Device";
        }

        private static int _numDevices;
        public static int NumDevices
        {
            get { return _numDevices; }
            set { if (value >= 0) _numDevices = value; }
        }

        public static bool IsDeviceAvailable()
        {
            if (NumDevices > 0)
                return true;
            else
                return false;
        }

        string Description();

        void PerformWrite(string Stuff);
    }

    internal class Pen : IRecordable
    {
        internal Pen()
        {
            IRecordable.NumDevices += 1;
        }

        ~Pen()
        {
            IRecordable.NumDevices -= 1;
        }

        // Uncomment this method to obtain a specific
        // implementation.
        //public string GetName()
        //{
        //    return "Pen";
        //}

        public string Description()
        {
            return "A device used for writing by hand.";
        }

        private bool PenWriting
        { get; set; }

        public void PerformWrite(string Stuff)
        {
            if (PenWriting)
            {
                Console.WriteLine("Pen is writing.");
                Console.WriteLine($"The paper contains: {Stuff}.");
            }
            else
                Console.WriteLine("Pen isn't writing.");
        }

        public void StopWriting()
        {
            PenWriting = false;
            Console.WriteLine("Pen off paper.");
        }

        public void StartWriting()
        {
            PenWriting = true;
            Console.WriteLine("Pen on paper.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pen available? {IRecordable.IsDeviceAvailable()}");
            IRecordable myPen = new Pen();

            Console.WriteLine($"Pen available? {IRecordable.IsDeviceAvailable()}");
            ((Pen)myPen).StartWriting();
            myPen.PerformWrite("Hello There!");
            Console.WriteLine($"Using a {myPen.GetName()}.");
            ((Pen)myPen).StopWriting();
            myPen.PerformWrite("Goodbye");
            Console.ReadLine();
        }
    }
}
