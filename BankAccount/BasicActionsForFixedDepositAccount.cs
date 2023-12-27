using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class BasicActionsForFixedDepositAccount : IBasicBankActions
    {
        private int userAge;
        public int UserAge { get => userAge; }
        public BasicActionsForFixedDepositAccount(int userAge)
        {
            this.userAge = userAge;
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
            if (userAge < 18)
            {
                Console.WriteLine("You do not have access");
            }
            else
            {
                if (balance >= withdrawAmount)
                {
                    balance -= withdrawAmount;
                }
                else
                {
                    Console.WriteLine("You do not have enough funds");
                }
            }
            return balance;
        }
    }
}
