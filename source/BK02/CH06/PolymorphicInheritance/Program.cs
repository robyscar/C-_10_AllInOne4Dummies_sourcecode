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

        internal virtual decimal Withdraw(decimal amount)
        {
            decimal amountToWithdraw = amount;

            if (amountToWithdraw > Balance)
            {
                amountToWithdraw = Balance;
            }
            Console.WriteLine($"In BankAccount.Withdraw() for " +
                $"${amountToWithdraw}.");

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
        internal override decimal Withdraw(decimal withdrawal)
        {
            // Take the $1.50 off the top.
            Console.WriteLine("Deductng the SavingsAccount fee.");
            base.Withdraw(1.5M);

            // Now you can withdraw from what's left.
            Console.WriteLine($"In SavingsAccount.Withdraw() for " +
                $"${withdrawal}.");
            return base.Withdraw(withdrawal);
        }
    }

    class Program
    {
        public static void MakeAWithdrawal(BankAccount ba, decimal amount)
        {
            ba.Withdraw(amount);
        }


        static void Main(string[] args)
        {
            BankAccount ba;
            SavingsAccount sa;

            // Create a bank account, withdraw $100, and
            // display the results.
            Console.WriteLine("Withdrawal: MakeAWithdrawal(ba, ...)");
            ba = new BankAccount(200M);
            MakeAWithdrawal(ba, 100M);
            Console.WriteLine("BankAccount balance is {0:C}", ba.Balance);

            // Try the same trick with a savings account.
            Console.WriteLine("\r\nWithdrawal: MakeAWithdrawal(sa, ...)");
            sa = new SavingsAccount(200M, 12);
            MakeAWithdrawal(sa, 100M);
            Console.WriteLine("SavingsAccount balance is {0:C}", sa.Balance);
            Console.Read();
        }
    }
}
