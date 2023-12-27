using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
   public class Account:IAccountActions
    {
        private int id;
        private string name;
        private string surName;
        private string email;
        private int balance;
        private IBasicBankActions actionsWithAccount;
        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Email { get => email; set => email = value; }
        public int Balance { get => balance; set => balance = value; }
        public IBasicBankActions ActionsWithAccount { get => actionsWithAccount; set => actionsWithAccount = value; }
        public Account(int id, string name, string surName, string email, int balance, IBasicBankActions actionsWithAccount)
        {
            this.id = id;
            this.name = name;
            this.surName = surName;
            this.email = email;
            this.balance = balance;
            this.actionsWithAccount = actionsWithAccount;
        }

        public string userCredeintials()
        {
            return name +" "+ surName;
        }

        public int checkBalance()
        {
            return balance;
        }
        public void addmoney(int sum)
        {
            balance=actionsWithAccount.deposit(balance, sum);
        }
        public void takeMoney(int sum) 
        { 
            balance=actionsWithAccount.withDraw(balance, sum);
        }
    }
}
