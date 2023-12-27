using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public interface IBasicBankActions
    {
        int withDraw(int balance, int withdrawAmount);
        int deposit(int balance, int deposit);
    }
}
