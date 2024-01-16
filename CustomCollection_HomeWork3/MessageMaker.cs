using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CustomCollection_HomeWork3
{
    internal class MessageMaker
    {
        public void AddMessage(object sender, EventArgs args)
        {
            Console.WriteLine("The element was added");
        }
        public void RemoveMessage(object sender, EventArgs args)
        {
            Console.WriteLine("The element was removed");
        }
    }
}
