using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Class1<T> : Itest<T>
    {
        T t;
         T Itest<T>.test()
        {
            Console.WriteLine("aaaa");
            return t;
        }
    }
}
