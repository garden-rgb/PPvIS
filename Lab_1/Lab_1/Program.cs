using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов:");
            int columns = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(columns,rows);
            
            var matrix1 = new CheckMatrix(columns,rows);

            var matrix2 = new Submatrix(columns, rows);

            var matrix3 = new TranspontMatrix(columns, rows);

            matrix.PrintMatrix();
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Создать новую матрицу \n 2. Определить тип матрицы \n 3. Вывести подматрицу \n" +
                "4. Транспонирование матрицы \n 5. Изменить размер матрицы \n 6. Читать матрицу из файла");
            
                int chooseOperation = int.Parse(Console.ReadLine());
            
                switch (chooseOperation)
                {
                    case 1:
                        matrix.CreateNewRandomMatrix();
                        matrix.PrintMatrix();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(matrix1.CheckSimetricMatrix());

                        Console.WriteLine(matrix1.CheckIdentityMatrix());

                        Console.WriteLine(matrix1.CheckSimetricMatrix());

                        Console.WriteLine(matrix1.CheckSquareMatrix());

                        Console.WriteLine(matrix1.CheckZeroMatrix());

                        Console.ReadKey();
                        break;
                    case 3:
                        matrix2.PrintSubmatrix();
                        Console.ReadKey();
                        break;
                    case 4:
                        matrix3.TransponceMatrix();
                        Console.ReadKey();
                        break;
                    case 5:
                        matrix.ChangeMatrixSize();
                        Console.ReadKey();
                        break;
                    case 6:
                        matrix.PrintMatrixFromFile();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
