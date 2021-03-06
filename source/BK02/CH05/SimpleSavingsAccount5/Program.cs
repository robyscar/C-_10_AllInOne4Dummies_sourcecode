using System;

namespace SimpleSavingsAccount
{
    // BankAccount -- Simulate a bank account, each of which
    //    carries an account ID (which is assigned
    //    on creation) and a balance.
    internal class BankAccount    // The base class
    {
        // Bank accounts start at 1000 and increase sequentially.
        private static int _nextAccountNumber = 1000;

        // Maintain the account number for each object.
        private int _accountNumber;

        // Constructor -- Initialize a bank account with the next account
        //  ID and the specified initial balance (default to zero).
        internal BankAccount() : this(0) { }

        internal BankAccount(decimal initialBalance)
        {
            _accountNumber = ++_nextAccountNumber;
            Balance = initialBalance;
        }

        // Balance property.
        protected decimal Balance
        { get; set; }

        // Deposit -- any positive deposit is allowed.
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Withdraw -- You can withdraw any amount up to the
        //    balance; return the amount withdrawn.
        public decimal Withdraw(decimal withdrawal)
        {
            if (Balance <= withdrawal) // Use Balance property.
            {
                withdrawal = Balance;
            }
            Balance -= withdrawal;
            return withdrawal;
        }

        // ToString - Stringify the account.
        public override string ToString()
        {
            return $"{_accountNumber} - {Balance:C}";
        }
    }

    // SavingsAccount -- A bank account that draws interest
    internal class SavingsAccount : BankAccount   // The subclass
    {
        private decimal _interestRate = 0;

        // InitSavingsAccount -- Input the rate expressed as a
        //    rate between 0 and 100.
        internal SavingsAccount(decimal interestRate) :
            this(0, interestRate)
        { }

        internal SavingsAccount(decimal initialBalance,
            decimal interestRate) : base(initialBalance)
        {
            _interestRate = interestRate / 100;
        }

        // AccumulateInterest -- Invoke once per period.
        public void AccumulateInterest()
        {
            Balance = Balance + (decimal)(Balance * _interestRate);
        }

        // ToString -- Stringify the account.
        public override string ToString()
        {
            return $"{base.ToString()} ({_interestRate:P})";
        }
    }

    class Program
    {
        public static void ProcessAmount(BankAccount bankAccount)
        {
            // Deposit a large sum to the account.
            bankAccount.Deposit(10000.00M);

            // If the object is a SavingsAccount
            if (bankAccount is SavingsAccount)
            {
                // then collect interest now.
                SavingsAccount savingsAccount = (SavingsAccount)bankAccount;
                savingsAccount.AccumulateInterest();
            }
        }

        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(100M, 12.5M);
            ProcessAmount(sa);
            Console.WriteLine(sa.ToString());

            BankAccount ba = new BankAccount(100M);
            ProcessAmount(ba);
            Console.WriteLine(ba.ToString());
            Console.Read();
        }
    }
}
