using System;

namespace BankAccount
{
    // BankAccount -- Define a class that represents a simple account.
    internal class BankAccount
    {
        private static int _nextAccountNumber = 1000;
        private int _accountNumber;

        // Maintain the balance as a double variable.
        private decimal _balance;

        // Init -- Initialize a bank account with the next
        //    account id and a balance of 0.
        internal protected void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = 0.0M;
        }

        // Balance property only obtains a balance.
        internal decimal Balance
        { get => _balance; }

        // AccountNumber property
        internal int AccountNumber
        { get => _accountNumber; set => _accountNumber = value; }

        // Deposit -- Any positive deposit is allowed.
        internal void Deposit(decimal amount)
        {
            if (amount > 0.0M)
            {
                // Round off the double to the nearest cent before depositing.
                decimal temp = amount;
                temp = Decimal.Round(temp, 2);

                _balance += temp;
            }
        }

        // Withdraw -- You can withdraw any amount up to the
        //    balance; return the amount withdrawn.
        internal decimal Withdraw(decimal withdrawal)
        {
            decimal temp = withdrawal;
            temp = Decimal.Round(temp, 2);

            if (_balance <= temp)
            {
                temp = _balance;
            }
            _balance -= temp;
            return temp;
        }

        // Return the account data as a string.
        public override string ToString()
        {
            return $"{AccountNumber} = {Balance:C}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Open a bank account.
            Console.WriteLine("Create a bank account object");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();

            // Make a deposit.
            decimal deposit = 123.454M;
            Console.WriteLine($"Depositing {deposit:C}");
            ba.Deposit(deposit);

            // Account balance
            Console.WriteLine(ba.ToString());

            // Here's the problem.
            decimal fractionalAddition = 0.002M;
            Console.WriteLine($"Adding {fractionalAddition:C}");
            ba.Deposit(fractionalAddition);

            // Resulting balance
            Console.WriteLine(ba.ToString());
            Console.Read();
        }
    }
}
