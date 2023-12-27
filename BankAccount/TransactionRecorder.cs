using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.BankAccount
{
    internal class TransactionRecorder:IDataRecorder
    {
        public int readFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    if (int.TryParse(line, out int parsedNumber))
                    {
                        return parsedNumber;
                    }
                    else
                    {
                        Console.WriteLine("Failed to parse the number.");
                    }
                }
            }
            return 0;
        }

        public void writeFile(string fileName,int data)
        {
           using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(data);
            }
        }
    }
}
