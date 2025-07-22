using System;

namespace LeetCode;

public class count_fertile_pyramids_in_a_land
{
    public int CountPyramids(int[][] grid) {
        int ret1 = CountPyramidsInner(grid);
        int l1 = grid.Length, l2 = grid[0].Length;
        for (int i = 0; i < l1/2; i++) {
            for (int j = 0; j < l2; j++) {
                int tmp = grid[i][j];
                grid[i][j] = grid[l1-1-i][j];
                grid[l1-1-i][j] = tmp;
            }
        }
        int ret2 = CountPyramidsInner(grid);
        return ret1 + ret2;
    }

    private int CountPyramidsInner(int[][] grid) {
        int l1 = grid.Length, l2 = grid[0].Length;
        int[,] dp = new int[l1, l2];
        int ret = 0;
        for (int i = l1 - 2; i >= 0; i--) {
            for (int j = 1; j < l2 - 1; j++) {
                if (grid[i][j] == 1) {
                    dp[i, j] = Min(dp[i+1, j], dp[i+1, j-1], dp[i+1, j+1]);
                    if (dp[i, j] != 0) {
                        dp[i, j]++;
                    } else {
                        dp[i, j] = (grid[i+1][j] == 1 && grid[i+1][j-1] == 1 && grid[i+1][j+1] == 1) ? 1 : 0;
                    }
                    ret += dp[i, j];
                }
            }
        }
        return ret;
    }

    private int Min(int a, int b, int c) {
        return Math.Min(Math.Min(a, b), c);
    }
}