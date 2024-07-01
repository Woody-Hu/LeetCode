using System;

namespace LeetCode;

public class find_the_minimum_area_to_cover_all_ones_i
{
    public int MinimumArea(int[][] grid) {
        var left = grid[0].Length;
        var right = 0;
        var top = grid.Length;
        var bottom = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }
                
                left = Math.Min(left, j);
                right = Math.Max(right, j);
                top = Math.Min(top, i);
                bottom = i;
            }
        }
        
        return (right - left + 1) * (bottom - top + 1);

    }
}