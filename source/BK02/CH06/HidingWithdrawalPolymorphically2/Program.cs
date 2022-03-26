using System;

namespace HidingWithdrawal
{
    // BankAccount -- A very basic bank account
    internal class BankAccount
    {
        internal BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        internal decimal Balance
        { get; private set; }

        internal decimal Withdraw(decimal amount)
        {
            // Good practice means avoiding modifying an input parameter.
            // Modify a copy.
            decimal amountToWithdraw = amount;

            if (amountToWithdraw > Balance)
            {
                amountToWithdraw = Balance;
            }

            Balance -= amountToWithdraw;
            return amountToWithdraw;
        }
    }

    // SavingsAccount -- A bank account that draws interest
    internal class SavingsAccount : BankAccount
    {
        private decimal InterestRate
        { get; set; }

        // SavingsAccount -- Input the rate expressed as a
        //    rate between 0 and 100.
        public SavingsAccount(decimal initialBalance, decimal interestRate)
        : base(initialBalance)
        {
            InterestRate = interestRate / 100;
        }

        // Withdraw -- You can withdraw any amount up to the
        //    balance; return the amount withdrawn.
        internal new decimal Withdraw(decimal withdrawal)
        {
            // Take the $1.50 off the top.
            base.Withdraw(1.5M);

            // Now you can withdraw from what's left.
            return base.Withdraw(withdrawal);
        }
    }

    class Program
    {
        public static void MakeAWithdrawal(BankAccount ba, decimal amount)
        {
            if (ba is SavingsAccount)
            {
                SavingsAccount sa = (SavingsAccount)ba;
                sa.Withdraw(amount);
            }
            else
            {
                ba.Withdraw(amount);
            }
        }

        static void Main(string[] args)
        {
            BankAccount ba;
            SavingsAccount sa;

            // Create a bank account, withdraw $100, and
            // display the results.
            ba = new BankAccount(200M);
            MakeAWithdrawal(ba, 100M);

            // Try the same trick with a savings account.
            sa = new SavingsAccount(200M, 12);
            MakeAWithdrawal(sa, 100M);

            // Display the resulting balance.
            Console.WriteLine("When invoked through intermediary:");
            Console.WriteLine("BankAccount balance is {0:C}", ba.Balance);
            Console.WriteLine("SavingsAccount balance is {0:C}", sa.Balance);
            Console.Read();
        }
    }
}
