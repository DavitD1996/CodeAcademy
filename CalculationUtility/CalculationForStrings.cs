using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CalculationUtility
{
    internal class CalculationForStrings : ICalculationUtility<String>
    {
        public string add(string value1, string value2)
        {
            return value1 + " "+value2;
        }

        public string divide(string value1, string value2)
        {
            throw new NotImplementedException();
        }

        public string multiply(string value1, string value2)
        {
            throw new NotImplementedException();
        }

        public string remainder(string value1, string value2)
        {
            throw new NotImplementedException();
        }

        public string subtract(string value1, string value2)
        {
            foreach(char c in value2)
            {
                if (value1.Contains(c))
                {
                    value1 = value1.Replace(c, '\0');
                }
            }
            return value1;
        }
    }
}
