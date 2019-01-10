using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Number_of_Islands
    {
        public int NumIslands(char[,] grid)
        {
            var count = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        ChangeValue(grid, i, j);
                        count++;
                    }
                }
            }

            return count;
        }

        private void ChangeValue(char[,] grid, int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && rowIndex < grid.GetLength(0) && columnIndex >= 0 && columnIndex < grid.GetLength(1) && grid[rowIndex, columnIndex] == '1')
            {
                grid[rowIndex, columnIndex] = '0';
                ChangeValue(grid, rowIndex - 1, columnIndex);
                ChangeValue(grid, rowIndex + 1, columnIndex);
                ChangeValue(grid, rowIndex , columnIndex - 1);
                ChangeValue(grid, rowIndex , columnIndex + 1);
            }
        }
    }
}
