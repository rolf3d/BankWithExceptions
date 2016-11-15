using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //BankAccount konto1 = new BankAccount(0.25);
            // Create a new bank account with 25 % interest rate
            // (is that legal...?)
            BankAccount theAccount = new BankAccount(10.0);
            try
            {
                BankAccount konto1 = new BankAccount(20);
                
            }
            catch (IllegalInterestRateException)
            {

                Console.WriteLine("Renten skal være mellem 0 og 20");
            }

            theAccount.Deposit(2000);


            // Should this be legal...?
            try
            {
                theAccount.Deposit(-1000);
            }
            catch (NegativeAmountException)
            {

                Console.WriteLine("Du prøver at indsætte et negativt beløb ind!");
            }
            

            // Try to withdraw...
            try
            {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }


            Console.WriteLine("Balance is now : " + theAccount.GetBalance());

            // The LAST line of code should be ABOVE this line
        }
    }
}
