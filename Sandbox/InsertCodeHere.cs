using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)
            BankAccount theAccount = null;

            try
            {
                // Change to 25.0 to provoke an exception
                theAccount = new BankAccount(15.0);
            }
            catch (IllegalInterestRateException)
            {
                Console.WriteLine("Illegal interest rate, must be between 0.0 and 20.0");
                return;
            }

            try
            {
                // Change to -2000 to provoke an exception
                theAccount.Deposit(2000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("Illegal amount, must be positive");
                return;
            }

            // Try to withdraw...
            try
            {
                // Change to 3000 or -1000 to provoke an exception
                theAccount.Withdraw(1000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("Illegal amount, must be positive");
                return;
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
