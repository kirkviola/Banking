using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings2
    {
        private Account account { get; set; }

        public int Id => account.Id; // Reads the data from account.
        public decimal Balance => account.Balance;
        public string Description
        {
            get { return account.Description; } // Passes description back from class.
            set { account.Description = value; } // Sets value from class.
        }
        public decimal InterestRate { get; set; } = 0.01m;
        
        // Recreating the interest method
        public decimal CalculateAndPayInterest (int months)
        {
            var interest = this.account.Balance * (InterestRate / 12) * months;
            this.account.Deposit(interest);
            return interest;
        }
        public Savings2(int id) // Default constructor creates a new instance of account
        {
            this.account = new Account();
            this.account.Id = 1;
            this.account.Description = "NewSavings2";
        }
        // These link us up to the methods from the account class
        public void Deposit(decimal amount)
        {
            this.account.Deposit(amount);
        }
            
        public void Withrawal(decimal amount)
        {
            this.account.Withdrawal(amount);
        }

        public void Transfer (decimal amount, Account ToAccount)
        {
            
            this.account.Transfer(amount, ToAccount);
        }

        public void Print()
        {
            this.account.Print();
        }
    }
}
