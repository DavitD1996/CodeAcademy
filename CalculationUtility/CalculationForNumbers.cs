using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CalculationUtility
{
    internal class CalculationForNumbers : ICalculationUtility<Double>
    {
        public double add(double value1, double value2)
        {
            return value1+value2;
        }

        public double divide(double value1, double value2)
        {
            return value1 / value2;
        }

        public double multiply(double value1, double value2)
        {
            return value1*value2;
        }

        public double remainder(double value1, double value2)
        {
            return value1% value2;
        }

        public double subtract(double value1, double value2)
        {
            return value1- value2;
        }
    }
}
