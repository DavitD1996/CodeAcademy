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
using Homework1.EmployeeManagement;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "j", 200);
            Console.WriteLine(emp.Salary);
            ReflectionMakers<Employee> reft = new ReflectionMakers<Employee>(emp);
            reft.TypePropertyNames();
        }
    }
}
