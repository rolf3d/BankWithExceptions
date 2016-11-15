﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BankAccount
    {
        // Balance of the account; must not become negative
        private double balance;

        // Interest rate of the account; must be between 0.0 and 20.0
        private double interestRate;


        public BankAccount(double interestRate)
        {
            this.interestRate = interestRate;
            this.balance = 0.0;
            if (interestRate < 0 || interestRate > 20)
            {
                throw new IllegalInterestRateException();
            }
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
            if (amount <= 0)
            {
                throw new NegativeAmountException();
            }
        }

        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                throw new WithdrawAmountTooLargeException();
            }

            balance = balance - amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
