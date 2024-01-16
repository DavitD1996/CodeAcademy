using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Observerlesson
{
    public class EmailObserver
    {
        public void Update(double data)
        {
            Console.WriteLine("aaaaa");
        }
        public void UpdateArgs(object sender, EventArgs e)
        {
            if(sender is BitCoinReader)
            {
               
            }
            Console.WriteLine(e.ToString());
        }
    }
}
