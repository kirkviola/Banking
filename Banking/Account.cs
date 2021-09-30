using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        private static int GeneratedId { get; set; }
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
                
            }
            this.Balance += amount;
            
        }
        public void Withdrawal(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new InsufficientFundsException(this.Balance, amount);    
            }
            else if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
            else
            this.Balance -= amount;
        }
        public void Transfer(decimal amount, Account ToAccount)
        {
            Withdrawal(amount);     // Removed bool stuff due to exceptions being thrown   
            ToAccount.Deposit(amount);
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }   

     
}
