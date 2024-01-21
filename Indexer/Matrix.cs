using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Indexer
{
   public class Matrix
    {
        private int[,] data;
        public Matrix(int columns, int rows)
        {
            data = new int[rows,columns];
        }
        public int Columns { get { return data.GetLength(1); } }
        public int Rows { get { return data.GetLength(0); } }
        public int this[int row, int column]
        {
            get {
                if (IsDataValid(row, column)){
                    return data[row, column];
                }
                Console.WriteLine("incorrect data");
                return 0;
            }
            set { if (IsDataValid(row, column))
                {
                    data[row, column] = value;
                }
                else {
                    Console.WriteLine("incorrect data");
                    return;
                } 
            }
        }
        private bool IsDataValid(int row, int column)
        {
            return (row < Rows && column < Columns);
        }

    }
}
