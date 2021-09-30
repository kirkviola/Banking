using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class InsufficientFundsException : Exception
    {
        public decimal CurrentBalance { get; set; }
        public decimal AmountToWithdraw { get; set; }

        public InsufficientFundsException(decimal balance, decimal withdraw) : base()
        {
            this.CurrentBalance = balance;
            this.AmountToWithdraw = withdraw;
        }
        public InsufficientFundsException() 
            : base() {}
        public InsufficientFundsException(string Message)
            : base(Message) { }
        public InsufficientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
