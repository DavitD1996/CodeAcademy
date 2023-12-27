using Homework1.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class BasicActionsForCheckingAccount : IBasicBankActions
    {
        private int overdraft;
        public int Overdraft { get => overdraft; set => overdraft = value; }

        public BasicActionsForCheckingAccount(int overdraft)
        {
            this.overdraft = overdraft;
        }
        public int deposit(int balance, int deposit)
        {
            if (deposit < 0)
            {
                Console.WriteLine("incorrect amount");
            }
            else
            {
                balance += deposit;
            }
            return balance;
        }

        public int withDraw(int balance, int withdrawAmount)
        {
            if (withdrawAmount > (balance*overdraft))
            {
                Console.WriteLine("you do not have enough funds");
            }
            else
            {
                balance -= withdrawAmount;
            }
            return balance;
        }
        public int checkPossibleOverDraft()
        {
            return overdraft;
        }
    }
}
