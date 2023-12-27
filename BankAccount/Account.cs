using Homework1.BankAccount;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
   public class Account:IAccountActions
    {
        private static int id=0;
        private String filePath= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MyFile.txt"+id);
        private string name;
        private string surName;
        private string email;
        private int balance;
        private IBasicBankActions actionsWithAccount;
        private readonly IDataRecorder recorder;
        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Email { get => email; set => email = value; }
        public int Balance { get => balance; set => balance = value; }
        public IBasicBankActions ActionsWithAccount { get => actionsWithAccount; set => actionsWithAccount = value; }
        public Account( string name, string surName, string email, int balance, IBasicBankActions actionsWithAccount, IDataRecorder recorder)
        {
            id++;
            this.name = name;
            this.surName = surName;
            this.email = email;
            this.balance = balance;
            this.actionsWithAccount = actionsWithAccount;
            this.recorder =recorder;
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
            balance = recorder.readFile(this.filePath);
            balance=actionsWithAccount.deposit(balance, sum);
            recorder.writeFile(this.filePath, balance);
        }
        public void takeMoney(int sum) 
        {
            balance = recorder.readFile(this.filePath);
            balance=actionsWithAccount.withDraw(balance, sum);
            recorder.writeFile(this.filePath,balance);
        }
    }
}
