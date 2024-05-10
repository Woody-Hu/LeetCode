using System;

namespace LeetCode;

public class cherry_pickup_ii
{
    public int CherryPickup(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var f = new int[n][];
        for (int i = 0; i < n; i++)
        {
            f[i] = new int[n];
            Array.Fill(f[i], -1);
        }
        
        var g = new int[n][];
        for (int i = 0; i < n; i++)
        {
            g[i] = new int[n];
            Array.Fill(g[i], -1);
        }
        
        f[0][n - 1] = grid[0][0] + grid[0][n - 1];
        for (int i = 1; i < m; ++i) {
            for (int j1 = 0; j1 < n; ++j1) {
                for (int j2 = 0; j2 < n; ++j2) {
                    int best = -1;
                    for (int dj1 = j1 - 1; dj1 <= j1 + 1; ++dj1) {
                        for (int dj2 = j2 - 1; dj2 <= j2 + 1; ++dj2) {
                            if (dj1 >= 0 && dj1 < n && dj2 >= 0 && dj2 < n && f[dj1][dj2] != -1) {
                                best = Math.Max(best, f[dj1][dj2] + (j1 == j2 ? grid[i][j1] : grid[i][j1] + grid[i][j2]));
                            }
                        }
                    }
                    g[j1][j2] = best;
                }
            }
            int[][] temp = f;
            f = g;
            g = temp;
        }

        int ans = 0;
        for (int j1 = 0; j1 < n; ++j1) {
            for (int j2 = 0; j2 < n; ++j2) {
                ans = Math.Max(ans, f[j1][j2]);
            }
        }
        
        return ans;
    }
}