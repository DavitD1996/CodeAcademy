using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CalculationUtility
{
    internal interface ICalculationUtility<T>
    {
        T add(T value1,T value2);
        T subtract(T value1,T value2);
        T multiply(T value1,T value2);
        T divide (T value1,T value2);
        T remainder(T value1,T value2);
    }
}
