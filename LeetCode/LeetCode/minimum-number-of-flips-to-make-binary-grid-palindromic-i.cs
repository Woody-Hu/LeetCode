using System;

namespace LeetCode;

public class minimum_number_of_flips_to_make_binary_grid_palindromic_i
{
    public int MinFlips(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        var difRows = 0;
        foreach (var item in grid)
        {
            for (var j = 0; j < n / 2; j++)
            {
                if (item[j] != item[n - j - 1])
                {
                    difRows++;
                }
            }
        }
        
        var difCols = 0;
        for (var i = 0; i < m / 2; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] != grid[m - i - 1][j])
                {
                    difCols++;
                }
            }
        }

        return Math.Min(difCols, difRows);

    }
}