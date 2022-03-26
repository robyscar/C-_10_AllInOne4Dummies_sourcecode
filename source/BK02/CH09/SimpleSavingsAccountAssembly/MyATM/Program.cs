using System;
using AccountLibrary;

namespace MyATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account and display it.
            BankAccount ba = new BankAccount(100M);
            ba.Deposit(100M);
            Console.WriteLine($"Account {ba.ToString()}");

            // Now a savings account
            SavingsAccount sa = new SavingsAccount(12.5M);
            sa.Deposit(100M);
            sa.AccumulateInterest();
            Console.WriteLine($"Account {sa.ToString()}");
            Console.Read();
        }
    }
}
