using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MagicSquaresInGrid
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            int returnValue = 0;

            for (int i = 0; i <= grid.GetLength(0)-3; i++)
            {
                for (int j = 0; j <= grid[i].GetLength(0)-3; j++)
                {
                    returnValue += InnerMethod(i, j, grid);
                }
                
            }

            return returnValue;
        }

        private int InnerMethod(int inputRowIndex,int inputColumnIndex,int[][] inputgrid)
        {
            int[] numberArray = new int[10];

            for (int i = inputRowIndex; i <= inputRowIndex + 2; i++)
            {
                for (int j = inputColumnIndex; j <= inputColumnIndex + 2; j++)
                {
                    if (inputgrid[i][j] < 10 && inputgrid[i][j] > 0)
                    {
                        if (0 != numberArray[inputgrid[i][j]])
                        {
                            return 0;
                        }
                        numberArray[inputgrid[i][j]]++;

                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            if (15 == inputgrid[inputRowIndex][inputColumnIndex] + inputgrid[inputRowIndex][inputColumnIndex + 1] + inputgrid[inputRowIndex][inputColumnIndex + 2] &&
             15 == inputgrid[inputRowIndex][inputColumnIndex] + inputgrid[inputRowIndex + 1][inputColumnIndex + 1] + inputgrid[inputRowIndex + 2][inputColumnIndex + 2] &&
             15 == inputgrid[inputRowIndex][inputColumnIndex] + inputgrid[inputRowIndex + 1][inputColumnIndex] + inputgrid[inputRowIndex + 2][inputColumnIndex] &&
             15 == inputgrid[inputRowIndex + 2][inputColumnIndex] + inputgrid[inputRowIndex + 2][inputColumnIndex + 1] + inputgrid[inputRowIndex + 2][inputColumnIndex + 2] &&
             15 == inputgrid[inputRowIndex][inputColumnIndex + 2] + inputgrid[inputRowIndex + 1][inputColumnIndex + 2] + inputgrid[inputRowIndex + 2][inputColumnIndex + 2] &&
             15 == inputgrid[inputRowIndex][inputColumnIndex + 2] + inputgrid[inputRowIndex + 1][inputColumnIndex + 1] + inputgrid[inputRowIndex + 2][inputColumnIndex])
            {

                return 1;
            }
            return 0;
        }
    }
}
