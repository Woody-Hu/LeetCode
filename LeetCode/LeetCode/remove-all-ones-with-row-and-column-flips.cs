using System;
namespace LeetCode
{
    public class remove_all_ones_with_row_and_column_flips
    {
        public bool RemoveOnes(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            for (int i = 1; i < n; i++)
            {
                var value = grid[i][0] ^ grid[0][0];
                for (int j = 1; j < m; j++)
                {
                    if ((grid[i][j] ^ grid[0][j]) != value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
