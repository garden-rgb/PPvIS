using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_1
{
    /// <summary>
    /// Родительский класс матрицы
    /// </summary>
    public class Matrix:IMatrix    
    {
        /// <summary>
        /// Путь к файлу с матрицей
        /// </summary>
        private readonly string fileWithMatrix = @"C:\Users\J\Desktop\matrix.txt";
        /// <summary>
        /// Матрица
        /// </summary>
        public double[,] matrix;
        /// <summary>
        /// Количество строк
        /// </summary>
        public int rows; 
        /// <summary>
        /// Количество столбцов
        /// </summary>
        public int columns; 
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
        public Matrix(int columns, int rows)
        {
            this.rows = rows;
            this.columns = columns;
            Random random = new Random();
            matrix = new double[rows, columns];
            for(int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = random.Next(0,100);
        }
        /// <summary>
        /// Метод, создающий новую матрицу
        /// </summary>
        public void CreateNewRandomMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = random.Next(0,100);
        }
        /// <summary>
        /// Метод для изменения размера матрицы
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public void ChangeMatrixSize()
        {
            Console.WriteLine("Введите количество строк:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            columns = int.Parse(Console.ReadLine());

            matrix = new double[rows, columns];
            CreateNewRandomMatrix();
        }
        /// <summary>
        /// Метод вывода матрицы
        /// </summary>
        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(String.Format("{0,3}", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод вывода матрицы из файла
        /// </summary>
        public void PrintMatrixFromFile()
        {
            ReadMatrixFromFile();
        }
        /// <summary>
        /// Метод чтения матрицы из файла
        /// </summary>
        private void ReadMatrixFromFile()
        {
            var matrixFromFile = File.ReadLines(fileWithMatrix).
                Select(line=>line.Split().Select(int.Parse).ToList()).
                ToList();
        }
    }
}
