using Homework1.BankAccount;
using Homework1.CalculationUtility;
using Homework1.CustomCollection_HomeWork3;
using Homework1.ExceptionHandling;
using Homework1.Indexer;
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
            Matrix a = new Matrix(2, 3);
            a[0, 1] = 1;
            Console.WriteLine(a[5, 1]);
        }

       
    }
}
