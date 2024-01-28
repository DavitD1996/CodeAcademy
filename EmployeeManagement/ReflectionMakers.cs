using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.EmployeeManagement
{
    public class ReflectionMakers<T> where T : class
    {
        private T reflectedObject;
        public ReflectionMakers(T reflectedObject)
        {
            this.reflectedObject = reflectedObject;
        }
        public void TypePropertyNames()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            if (properties != null)
            {
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"{property.Name} is {property.PropertyType} {property.GetValue(reflectedObject)}");
                }
            }
        }
        public void MethodNames()
        {
            MethodInfo[]methods= typeof(T).GetMethods();
            if (methods != null)
            {
                foreach(MethodInfo method in methods)
                {
                    Console.WriteLine($"{method.Name} {method.GetParameters()}");
                }
            }
        }
    }
}
