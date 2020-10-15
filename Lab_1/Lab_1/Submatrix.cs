using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    /// <summary>
    /// Класс вывода подматрицы 
    /// </summary>
    public class Submatrix : Matrix
    {
        public Submatrix(int columns, int rows) : base(columns,rows)
        {
        }
        /// <summary>
        /// Метод вывода подматрицы
        /// </summary>
        public void PrintSubmatrix()
        {
            int newColumns = int.Parse(Console.ReadLine());
            int newRows = int.Parse(Console.ReadLine());
        
            Matrix submatrix = new Matrix(newColumns,newRows);
            
            for (int i = 0; i < columns; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if (columns < newColumns || rows < newRows)
                    {
                         matrix[i, j] = 0;
                        Console.Write(matrix[i, j]);
                        break;
                    }
                    Console.Write(matrix[i,j]);
                }
            }
        }
    }
}
