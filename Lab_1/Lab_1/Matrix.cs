using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_1
{
    class Matrix:IMatrix    
    {
        private const string fileWithMatrix = @"C:\Users\J\Desktop\matrix.txt";

        public double[,] matrix;
        public int rows;
        public int columns;
        public Matrix(int columns, int rows)
        {
            this.rows = rows;
            this.columns = columns;
            Random random = new Random();
            matrix = new double[columns, rows];
        }
        
        static double[][] CreateMatrix(int rows, int columns)
        {

        }
        static double [][] RandomMatrix(int rows, int columns, int seed)
        {
            Random random = new Random(seed);
            double[][] result = CreateMatrix(rows, columns);
            return result;
        }

        public void ChangeMatrixSize(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new double[rows, columns];

        }
        private void ReadMatrixFromFile()
        {
            var serializedMatrix = File.ReadLines(fileWithMatrix).
                Select(line=>line.Split(unwanted).Select(int.Parse).ToList).
                ToList;
        }
    }
}
