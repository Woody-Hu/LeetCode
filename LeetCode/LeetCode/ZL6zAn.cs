using System;

namespace LeetCode;

public class ZL6zAn
{
    public int MaxAreaOfIsland(int[][] grid) {
        int ans = 0;
        for (int i = 0; i != grid.Length; ++i) {
            for (int j = 0; j != grid[0].Length; ++j) {
                ans = Math.Max(ans, DFS(grid, i, j));
            }
        }
        
        return ans;
    }
    
    private int DFS(int[][] grid, int curI, int curJ) {
        if (curI < 0 || curJ < 0 || curI == grid.Length || curJ == grid[0].Length || grid[curI][curJ] != 1) {
            return 0;
        }
        grid[curI][curJ] = 0;
        int[] di = {0, 0, 1, -1};
        int[] dj = {1, -1, 0, 0};
        int ans = 1;
        for (int index = 0; index != 4; ++index) {
            int nextI = curI + di[index], nextJ = curJ + dj[index];
            ans += DFS(grid, nextI, nextJ);
        }
        
        return ans;
    }
}