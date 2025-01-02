using System;

namespace LeetCode;

public class minimum_operations_to_make_columns_strictly_increasing
{
    public int MinimumOperations(int[][] grid)
    {
        var res = 0;
        for (var j =0;j < grid[0].Length;j++)
        {
            var pre = -1;
            foreach (var row in grid)
            {
                var x = row[j];
                res += Math.Max(pre + 1 - x, 0);
                pre = Math.Max(pre + 1, x);
                
            }
        }
        
        return res;

    }
}