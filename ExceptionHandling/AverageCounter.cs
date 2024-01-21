using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ExceptionHandling
{
    public  class AverageCounter
    {
        private FileHandler file;
        private String pathForOutput;
        public AverageCounter(FileHandler handler,String pathForOutput)
        {
            file = handler;
            this.pathForOutput = pathForOutput;
        }
        private int CountAverageFromFile()
        {
            int result = 0;
            List<String> data = file.ReadFromFile();
            foreach(var i in data)
            {
                int.TryParse(i, out int amount );
                result += amount;
            }
            return result/data.Count;
        }
        public void PrintAverageSum()
        {
            Console.WriteLine(CountAverageFromFile());
            file.WriteIntoFile(pathForOutput,CountAverageFromFile());
        }

    }
}
