using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinimumPathSum
    {
        public int MinPathSum(int[,] grid)
        {
            if (grid.Length == 0)
            {
                return 0;
            }

            int rowLength = grid.GetLength(0);

            int columnLength = grid.GetLength(1);

            int[,] dpData = new int[rowLength, columnLength];

            dpData[0, 0] = grid[0, 0];

            for (int i = 1; i < rowLength; i++)
            {
                dpData[i, 0] = dpData[i - 1, 0] + grid[i, 0];
            }

            for (int i = 1; i < columnLength; i++)
            {
                dpData[0, i] = dpData[0, i - 1] + grid[0, i];
            }

            for (int i = 1; i < rowLength; i++)
            {
                for (int j = 1; j < columnLength; j++)
                {
                    dpData[i, j] = Math.Min(dpData[i - 1, j], dpData[i, j - 1]) + grid[i, j];
                }
            }

            return dpData[rowLength - 1, columnLength - 1];
        }

    }
}
