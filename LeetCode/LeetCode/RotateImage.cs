using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotateImage
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int useValue = n - 1;
            int[,] returnValue = new int[n, n];
            int tempValue;

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                tempValue = useValue - rowIndex;
                for (int columnIndex = 0; columnIndex < n; columnIndex++)
                {
                    returnValue[columnIndex, tempValue] = matrix[rowIndex, columnIndex];
                }
            }

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < n; columnIndex++)
                {
                    matrix[rowIndex, columnIndex] = returnValue[rowIndex, columnIndex]; 
                }
            }

            return ;


        }
    }
}
