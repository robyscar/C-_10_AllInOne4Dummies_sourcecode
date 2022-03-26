using System;

namespace CalculateInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter source principal.
            Console.Write("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);

            // Make sure that the principal is not negative.
            if (principal < 0)
            {
                Console.WriteLine("Principal cannot be negative");
                principal = 0;
            }

            // Enter the interest rate.
            Console.Write("Enter interest: ");
            string interestInput = Console.ReadLine();
            decimal interest = Convert.ToDecimal(interestInput);

            // Make sure that the interest is not negative either.
            if (interest < 0)
            {
                Console.WriteLine("Interest cannot be negative");
                interest = 0;
            }

            // Calculate the value of the principal plus interest.
            decimal interestPaid = principal * (interest / 100);

            // Now calculate the total.
            decimal total = principal + interestPaid;

            // Output the result.
            Console.WriteLine();  // Skip a line.
            Console.WriteLine("Principal     = " + principal);
            Console.WriteLine("Interest      = " + interest + "%");
            Console.WriteLine();
            Console.WriteLine("Interest paid = " + interestPaid);
            Console.WriteLine("Total         = " + total);
            Console.Read();
        }
    }
}
