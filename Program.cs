using Homework1.BankAccount;
using Homework1.CalculationUtility;
using Homework1.CustomCollection_HomeWork3;
using Homework1.Observerlesson;
using Homework1.Shopping_System;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageMaker m = new MessageMaker();
            CustomStack<int> slave = new CustomStack<int>();
            slave.AddElement += m.AddMessage;
            slave.RemoveElement += m.RemoveMessage;
            slave.Push(1);
            slave.Push(2);
            slave.Push(3);
            slave.Push(4);
            slave.Push(5);
            slave.Pop();
            slave.Pop();
            slave.Pop();
            slave.Pop();
            slave.Pop();
            Console.WriteLine(slave.Peek());
            
        }

       
    }
}
