using System;
using System.Text;

namespace UseStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("012");
            builder.Append("34");
            builder.Append("56");
            Console.WriteLine(builder.ToString());

            StringBuilder builder2 = new StringBuilder();
            builder2.Append(5);
            builder2.Append(true);
            builder2.Append(9.9);
            builder2.Append(2 + 4);
            Console.WriteLine(builder2.ToString());

            StringBuilder sb = new StringBuilder("jones");
            sb[0] = char.ToUpper(sb[0]);
            Console.WriteLine(sb.ToString());
        }
    }
}
