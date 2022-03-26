using System;

namespace StructWithElements
{
    public struct Message
    {
        private int msgID;
        public int ProductID;
        public int Qty;
        public double Price;

        // Provide a generic product constant.
        public const int genericProduct = 22;

        public int MsgID { get => msgID; set => msgID = value; }

        public static double CalculatePrice(double SinglePrice, int Qty)
        {
            return SinglePrice * Qty;
        }

        public Message(
            int msgId, int productId = 22, int qty = 5)
        {
            // Provided by the user.
            msgID = msgId;
            ProductID = productId;
            Qty = qty;

            // Defined by the application.
            if (ProductID == 22)
                Price = CalculatePrice(5.99, qty);
            else
                Price = CalculatePrice(6.99, qty);
        }
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

            Message myMsg2 = new Message(2);
            Console.WriteLine(
                $"In response to Msg {myMsg2.MsgID}, you can get {myMsg2.Qty} " +
                $"of {myMsg2.ProductID} for ${myMsg2.Price}.");

            Message myMsg3 = new Message(3, Message.genericProduct);
            Console.WriteLine(
                $"In response to Msg {myMsg3.MsgID}, you can get {myMsg3.Qty} " +
                $"of {myMsg3.ProductID} for ${myMsg3.Price}.");

            Console.ReadLine();
        }
    }
}
