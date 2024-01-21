using Homework1.BankAccount;
using Homework1.CalculationUtility;
using Homework1.CustomCollection_HomeWork3;
using Homework1.CustomConversion;
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
using System.Reflection;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\sargs\source\repos\Homework1\ConsoleApp1.exe");
            var cla = assembly.GetType("ConsoleApp1.Testak");
            var instance=Activator.CreateInstance(cla);
            Type type=instance.GetType();
            FieldInfo f=type.GetField()
            MethodInfo arte = type.GetMethod("met");
            arte.Invoke(instance, new object[1] {2});
          
        }
    }
}
