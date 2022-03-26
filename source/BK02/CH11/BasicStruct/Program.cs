using System;

namespace BasicStruct
{
    public struct Message
    {
        public int MsgID;
        public int ProductID;
        public int Qty;
        public double Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the struct.
            Message myMsg = new Message();

            // Create a message.
            myMsg.MsgID = 1;
            myMsg.ProductID = 22;
            myMsg.Qty = 5;

            // Compute the price.
            myMsg.Price = 5.99 * myMsg.Qty;

            // Display the struct on screen.
            Console.WriteLine(
                $"In response to Msg {myMsg.MsgID}, you can get {myMsg.Qty} " +
                $"of {myMsg.ProductID} for ${myMsg.Price}.");
            Console.ReadLine();
        }
    }
}
