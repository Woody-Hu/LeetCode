using System;
namespace LeetCode
{
    public class count_negative_numbers_in_a_sorted_matrix
    {
        public int CountNegatives(int[][] grid)
        {
            var rows = grid.Length;
            var columns = grid[0].Length;
            var res = 0;
            var i = 0;
            var j = columns - 1;
            while (i < rows && j >= 0)
            {
                if (grid[i][j] < 0)
                {
                    res += rows - i;
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return res;
        }
    }
}
