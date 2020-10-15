using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    /// <summary>
    /// Класс проверки типа матрицы
    /// </summary>
    public class CheckMatrix : Matrix
    {
        public CheckMatrix(int columns, int rows) : base(columns,rows)
        {   
        }
        /// <summary>
        /// Проверка на квадратную матрицу
        /// </summary>
        public bool CheckSquareMatrix()
        {
            if (columns == rows)
            {
                Console.WriteLine("Матрица квадратная");
                return true;
            }
            else {
                Console.WriteLine("Матрица не квадратная");
                return false;
                 }
        }
        /// <summary>
        /// Проверка на единичную матрицу
        /// </summary>
        public bool CheckIdentityMatrix()
        {
            if (columns != rows)
            {
                Console.WriteLine("Матрица не единичная");
                return false;
            }
            for (int i = 0; i < columns; i++)
            {
                if (matrix[i, i] != 1)
                {
                    Console.WriteLine("Матрица не единичная");
                    return false;
                }
            }
            for(int i = 0; i < columns; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if (i != j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            Console.WriteLine("Матрица не единичная");
                            return false;
                        }
                    }
                    else continue;
                }
            }
            Console.WriteLine("Матрица единичная");
            return true;
        }
        /// <summary>
        /// Проверка на нулевую матрицу
        /// </summary>
        public bool CheckZeroMatrix()
        {
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    if (matrix[i, j] != 0)
                    {
                        Console.WriteLine("Матрица не нулевая");
                        return false;
                    }
            Console.WriteLine("Матрица нулевая");
            return true;
        }
        /// <summary>
        /// Проверка на диагональную матрицу
        /// </summary>
        public bool CheckDiagonalicMatrix()
        {
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    if (i != j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            Console.WriteLine("Матрица не диагональная");
                            return false;
                        }
                    }
                    else
                         continue;
            Console.WriteLine("Матрица диагональная");
            return true;
        }
        /// <summary>
        /// Проверка на симметричную матрицу
        /// </summary>
        public bool CheckSimetricMatrix()
        {
            if (columns != rows)
            {
                Console.WriteLine("Матрица не симметричная");
                return false;
            }
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    if (i - j < 0)
                        if (matrix[i, j] != matrix[j, i])
                        {
                            Console.WriteLine("Матрица не симметричная");
                            return false;
                        }
            Console.WriteLine("Матрица симметричная");
            return true;
        }
    }
}
