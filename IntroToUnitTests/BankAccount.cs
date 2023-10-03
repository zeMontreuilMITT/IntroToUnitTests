using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToUnitTests
{
    public class BankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public decimal Withdraw(decimal withdrawalAmount)
        {
            if (withdrawalAmount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(withdrawalAmount), "Withdrawal amount must be greater than zero");
            }

            if(withdrawalAmount > Balance)
            {
                throw new InvalidOperationException("Cannot withdraw an amount greater than the current balance");
            }

            Balance -= withdrawalAmount;
            return Balance;
        }

        public BankAccount(decimal newBalance)
        {
            if (newBalance >= 0)
            {
                Balance = newBalance;
            } else
            {
                throw new ArgumentOutOfRangeException(nameof(newBalance), "Cannot initialize a Bank Account with a negative balance.");
            }
        }
        
    }
}
