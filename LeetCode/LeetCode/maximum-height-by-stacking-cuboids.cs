using System;

namespace LeetCode;

public class maximum_height_by_stacking_cuboids
{
    public int MaxHeight(int[][] cuboids) {
        int n = cuboids.Length;
        foreach (int[] v in cuboids) {
            Array.Sort(v);
        }
        Array.Sort(cuboids, (a, b) => (a[0] + a[1] + a[2]) - (b[0] + b[1] + b[2]));
        int ans = 0;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++) {
            dp[i] = cuboids[i][2];
            for (int j = 0; j < i; j++) {
                if (cuboids[i][0] >= cuboids[j][0] && 
                    cuboids[i][1] >= cuboids[j][1] && 
                    cuboids[i][2] >= cuboids[j][2]) {
                    dp[i] = Math.Max(dp[i], dp[j] + cuboids[i][2]);
                }
            }
            ans = Math.Max(ans, dp[i]);
        }
        return ans;
    }
}