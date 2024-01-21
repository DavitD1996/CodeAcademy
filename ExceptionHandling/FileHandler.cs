using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ExceptionHandling
{
    public class FileHandler
    {
        private String path;
        private String logFile;
        public FileHandler(String path, String logFile)
        {
            this.path = path;
            this.logFile = logFile;
        }
        public void CreateFile()
        {
            try
            {
                using (FileStream file = new FileStream(path, FileMode.OpenOrCreate)) { };
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is a problem with file");
                WriteLog(ex);
            }
        }
        public List<String> ReadFromFile()
        {
            List<String> data=new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    String line;
                    while ((line=reader.ReadLine()) != null)
                    {
                        data.Add(line);
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("I am sorry the file was not found");
                WriteLog(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("I am sorry we found non numeric data");
                WriteLog(ex);
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is a problem with file");
                WriteLog(ex);
            }
            return data;
        }
        public void WriteIntoFile(int data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(data);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("I am sorry the file was not found");
                WriteLog(ex);
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is a problem with file");
                WriteLog(ex);
            }
        }
        public void WriteIntoFile(string path, int data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(data);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("I am sorry the file was not found");
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is a problem with file");
            }
        }
        private void WriteLog(Exception ex)
        {
            using(StreamWriter writer=new StreamWriter(logFile))
            {
                writer.WriteLine(ex.Message);
            }
        }

    }
}
