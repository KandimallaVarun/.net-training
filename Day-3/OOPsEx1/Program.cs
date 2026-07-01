using System;

namespace OOPsEx1
{
    class BankAccount
    {
        public long AccountNumber { get; } 
        public string AccountHolderName { get; set; }
        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount(long accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;

            if (initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else
            {
                balance = 0;
                Console.WriteLine("Initial balance cannot be negative. Balance set to 0.");
            }
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully.");
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully.");
        }

        // Display Account Details
        public void Display()
        {
            Console.WriteLine("\n----------- Account Details -----------");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Account Holder : {AccountHolderName}");
            Console.WriteLine($"Balance        : ₹{balance}");
            Console.WriteLine("---------------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1234567890, "Zombie", 5000);

            account.Display();

            Console.WriteLine();
            account.Deposit(2000);

            account.Withdraw(1500);

            account.Deposit(-500);

            account.Withdraw(10000);

            account.Display();

            Console.ReadKey();
        }
    }
}