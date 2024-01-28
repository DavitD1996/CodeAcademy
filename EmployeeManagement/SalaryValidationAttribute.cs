using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.EmployeeManagement
{
    [AttributeUsage(AttributeTargets.All)]
    public class SalaryValidationAttribute:Attribute
    {
        public double minimum { get; }
       public double maximum { get; }
        public SalaryValidationAttribute(double minimum, double maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }
    }
}
