using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i,j] != matrix[i + 1,j + 1]) return false;
                }
            }
            return true;

        }
    }
}
