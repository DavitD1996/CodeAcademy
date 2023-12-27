using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.BankAccount
{public  interface IDataRecorder
    {
        int readFile(string fileName);
        void writeFile(string filename, int data);
    }
}
