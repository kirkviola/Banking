using System;

namespace Banking
{
    class Program
    {
  
        static void Main(string[] args)
        {


            try
            {
                var sav2 = new Savings2(100);
                sav2.Description = "second savings";
                sav2.InterestRate = 0.12m;
                sav2.Print();
                sav2.Deposit(5000);
                sav2.Withrawal(20000);
                sav2.Print();
            } catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Insufficient funds");
                Console.WriteLine($"Current balance: {ex.CurrentBalance} Amount attempted: {ex.AmountToWithdraw}");
            } catch (AmountGreaterThanZeroException)
            {
                Console.WriteLine("Invalid Amount");
            } catch(Exception)
            {
                Console.WriteLine("Call your programmer at 2 am");
            }
            //var sav1 = new Savings()
            //{ Id = 10, Description = "My first savings" };
            //var acct1 = new Account() { 
            //Id = 1, Description = "Test Account"
            //};
            //sav1.InterestRate = 0.12m;
            //sav1.Deposit(5000);
            //sav1.Print();
            //sav1.Withdrawal(2000);
            //sav1.Print();
            //sav1.CalculateAndPayInterest(1);
            //sav1.Print();


            //var acct2 = new Account()
            //{
            //    Id = 2,
            //    Description = "New Account"
            //};

            //acct1.Transfer(1500, acct2);
            //acct1.Print();
            //acct2.Print();

            //acct1.Withdrawal(0);
            //acct1.Print();
        }
    }
}
