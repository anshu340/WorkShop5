using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop5
{
    internal class BankAccount
    {
            // Private fields
            private string accountNumber;
            private double balance;

            // Constructor
            public BankAccount(string accountNumber, double initialBalance)
            {
                this.accountNumber = accountNumber;
                // Use the property setter to validate initial balance
                Balance = initialBalance;
            }

            // Public property for AccountNumber (get only)
            public string AccountNumber
            {
                get { return accountNumber; }
            }

            // Public property for Balance with validation (doesn't allow negative or 0 values)

            public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: Balance cannot be negative or zero!");
                    return;
                }
                balance = value;
            }
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive!");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited: ${amount:F2}");
        }


        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive!");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Error: Insufficient balance!");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount:F2}");
        }

        // Display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"\nAccount Number: {AccountNumber}");
            Console.WriteLine($"Current Balance: ${Balance:F2}");
        }
    }
}
