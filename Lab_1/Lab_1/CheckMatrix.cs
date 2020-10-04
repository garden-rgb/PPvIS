using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class CheckMatrix : Matrix
    {
        public CheckMatrix(int columns, int rows)
        {

        }

        public bool CheckSquareMatrix()
        {
            if (columns == rows)
                return true;
            else return false;
        }

        public bool CheckIdentityMatrix()
        {
            if (columns != rows)
                return false;
            for (int i = 0; i < columns; i++)
            {
                if (matrix[i,i] != 1)
                    return false;
            }
            for(int i = 0; i < columns; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if (i != j)
                    {
                        if (matrix[i, j] != 0)
                            return false;
                    }
                    else continue;
                }
            }
            return true;
        }

        public bool CheckZeroMatrix()
        {
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    if (matrix[i, j] != 0)
                        return false;
            return true;
        }
    }
}
