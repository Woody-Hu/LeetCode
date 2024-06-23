namespace LeetCode;

public class check_if_grid_satisfies_conditions
{
    public bool SatisfiesConditions(int[][] grid) {
        int n = grid.Length;
        var m = grid[0].Length;
        for (int i = 0; i < n; i++) {             
            for (int j = 0; j < m; j++) {
                if (j > 0 && grid[i][j] == grid[i][j - 1] || i > 0 && grid[i][j] != grid[i - 1][j]) {
                    return false;
                }
            }
        }
        return true;
        

    }
}