using System;

namespace BankAccount
{
    // BankAccount -- Define a class that represents a simple account.
    public class BankAccount
    {
        private static int _nextAccountNumber = 1000;
        private int _accountNumber;

        // Maintain the balance as a double variable.
        private double _balance;

        // Init -- Initialize a bank account with the next
        //    account id and a balance of 0.
        public void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = 0.0;
        }

        // Balance property only obtains a balance.
        public double Balance
        { get => _balance; }

        // AccountNumber property
        public int AccountNumber
        { get => _accountNumber; set => _accountNumber = value; }

        // Deposit -- Any positive deposit is allowed.
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                _balance += amount;
            }
        }

        // Withdraw -- You can withdraw any amount up to the
        //    balance; return the amount withdrawn.
        public double Withdraw(double withdrawal)
        {
            if (_balance <= withdrawal)
            {
                withdrawal = _balance;
            }
            _balance -= withdrawal;
            return withdrawal;
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
            double deposit = 123.454;
            Console.WriteLine($"Depositing {deposit:C}");
            ba.Deposit(deposit);

            // Account balance
            Console.WriteLine(ba.ToString());

            // Here's the problem.
            double fractionalAddition = 0.002;
            Console.WriteLine($"Adding {fractionalAddition:C}");
            ba.Deposit(fractionalAddition);

            // Resulting balance
            Console.WriteLine(ba.ToString());
            Console.Read();
        }
    }
}
