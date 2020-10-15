using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    /// <summary>
    /// Класс транспонирования матрицы
    /// </summary>
    public class TranspontMatrix:Matrix
    {
        public TranspontMatrix(int columns, int rows) : base(columns,rows)
        {

        }
        /// <summary>
        /// Метод транспонировая матрицы
        /// </summary>
        public double[,] TransponceMatrix()
        {
            double[,] transponceMatrix = new double[columns, rows];
            Console.WriteLine("New transponce matrix:");
            Console.WriteLine();
            for(int i = 0; i < columns; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    transponceMatrix[i, j] = matrix[j, i];
                    Console.Write(transponceMatrix[i, j] + "\t");
                    if (j == rows - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            return transponceMatrix;
        }
    }
}
