using System.Collections.Generic;

namespace LeetCode;

public class zigzag_grid_traversal_with_skip
{
    public IList<int> ZigzagTraversal(int[][] grid)
    {
        var n = grid[0].Length;
        var end = n - 1 - n % 2;
        var result = new List<int>();
        for (int i = 0; i < grid.Length; i++) {
            if (i % 2 > 0) {
                for (int j = end; j >= 0; j -= 2) {
                    result.Add(grid[i][j]);
                }
            } else {
                for (int j = 0; j < n; j += 2) {
                    result.Add(grid[i][j]);
                }
            }
        }

        return result;

    }
}