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
            Console.WriteLine("This program doesn't compile.");

            // Open a bank account.
            Console.WriteLine("Create a bank account object");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();

            // Accessing the balance via the Deposit() method is okay --
            // Deposit() has access to all the data members.
            ba.Deposit(10);

            // Accessing the data member directly is a compile-time error.
            Console.WriteLine("Just in case you get this far the following is "
                            + "supposed to generate a compile error");

            // This line is wrong.
            ba._balance += 10;

            // Replace it with this line.
            //ba.Deposit(10);
            Console.Read();
        }
    }
}
