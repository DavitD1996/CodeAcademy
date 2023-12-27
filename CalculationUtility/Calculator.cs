using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CalculationUtility
{
    internal class Calculator<T>
    {
        private ICalculationUtility<T> calculator;
        public Calculator(ICalculationUtility<T> calculator)
        {
            this.calculator = calculator;
        }
        public T addOpertaion(T value1, T value2)
        {
           return calculator.add(value1,value2);
        }
        public T subtractOpertaion(T value1, T value2)
        {
            return calculator.subtract(value1, value2);
        }
        public T multiplyOpertaion(T value1, T value2)
        {
            return calculator.multiply(value1, value2);
        }
        public T divideOpertaion(T value1, T value2)
        {
            return calculator.divide(value1, value2);
        }
        public T remainderOpertaion(T value1, T value2)
        {
            return calculator.remainder(value1, value2);
        }
    }
}
