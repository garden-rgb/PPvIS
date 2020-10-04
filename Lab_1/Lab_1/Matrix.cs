using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_1
{
    public class Matrix:IMatrix    
    {
        private const string fileWithMatrix = @"C:\Users\J\Desktop\matrix.txt";

        public double[,] matrix;

        public int rows; //количество строк

        public int columns; // количество столбцов 
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
        static double [][] RandomMatrix(int rows, int columns)
        {
            Random random = new Random();
            double[][] result = CreateMatrix(rows, columns);
            return result;
        }

        public void ChangeMatrixSize(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new double[rows, columns];
        }
        private void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; i < columns; i++)
                {
                    Console.Write(matrix[rows, columns].ToString(" "));
                    Console.WriteLine();
                }
            }
        }
        private void ReadMatrixFromFile()
        {
            var serializedMatrix = File.ReadLines(fileWithMatrix).
                Select(line=>line.Split().Select(int.Parse).ToList).
                ToList;
        }
    }
}
