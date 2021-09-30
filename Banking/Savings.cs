using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.01m;

        // Will deposit into instance called.
        public decimal CalculateAndPayInterest(int months)
        {
            var interest = Balance * (InterestRate / 12) * months;
            this.Deposit(interest);
            return interest;
        }
    }



}
