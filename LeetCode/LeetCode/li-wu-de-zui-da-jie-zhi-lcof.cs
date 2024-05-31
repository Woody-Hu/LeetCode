using System;

namespace LeetCode;

public class li_wu_de_zui_da_jie_zhi_lcof
{
    public int JewelleryValue(int[][] frame) {
        var m = frame.Length;
        var n = frame[0].Length;
        var dp = new int[m + 1, n + 1];
        for (var i = 1; i <= m; i++) {
            for (var j = 1; j <= n; j++) {
                dp[i, j] = Math.Max(dp[i - 1, j], Math.Max(dp[i,j], dp[i, j - 1]));
                
                dp[i, j] += frame[i - 1][j - 1];
            }
        }
        
        return dp[m, n];
    }
}