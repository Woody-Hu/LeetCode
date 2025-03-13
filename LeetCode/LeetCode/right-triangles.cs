using System.Linq;

namespace LeetCode;

public class right_triangles
{
    public long NumberOfRightTriangles(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        int[] col = new int[m];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                col[j] += grid[i][j];
            }
        }
        long res = 0;
        for (int i = 0; i < n; i++) {
            int row = grid[i].Sum();
            for (int j = 0; j < m; j++) {
                if (grid[i][j] == 1) {
                    res += (row - 1) * (col[j] - 1);
                }
            }
        }
        return res;
    }
}