using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.EmployeeManagement
{
    public class Employee
    {
        private int id;
        public string Name { get; set; }
        private double salary;
        public int Id { get => id; set => id = value; }
        [SalaryValidation(1000, 5000)]
        public double Salary { get => salary; set => salary = salaryChecker(value,1000,5000); }
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            Name = name;
            PropertyInfo property = typeof(Employee).GetProperty("Salary");
            SalaryValidationAttribute attribute = property.GetCustomAttribute<SalaryValidationAttribute>();
            this.salary = salaryChecker(salary, attribute.minimum, attribute.maximum);
        }
        private double salaryChecker(double salary, double minSalary, double maxSalary)
        {
            if (salary < minSalary || salary > maxSalary)
            {
                Console.WriteLine("Tye typed data is incorrect");
                return minSalary;
            }
            return salary;
        }
    }
}
