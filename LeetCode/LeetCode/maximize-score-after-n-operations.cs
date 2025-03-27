using System;

namespace LeetCode;

public class maximize_score_after_n_operations
{
    public int MaxScore(int[] nums) {
        int m = nums.Length;
        int[] dp = new int[1 << m];
        int[][] gcdTmp = new int[m][];
        for (int i = 0; i < m; ++i) {
            gcdTmp[i] = new int[m];
            for (int j = i + 1; j < m; ++j) {
                gcdTmp[i][j] = GCD(nums[i], nums[j]);
            }
        }
        int all = 1 << m;
        for (int s = 1; s < all; ++s) {
            int t = BitCount(s);
            if ((t & 1) != 0) {
                continue;
            }
            for (int i = 0; i < m; ++i) {
                if (((s >> i) & 1) != 0) {
                    for (int j = i + 1; j < m; ++j) {
                        if (((s >> j) & 1) != 0) {
                            dp[s] = Math.Max(dp[s], dp[s ^ (1 << i) ^ (1 << j)] + t / 2 * gcdTmp[i][j]);
                        }
                    }
                }
            }
        }
        return dp[all - 1];
    }

    public int GCD(int num1, int num2) {
        while (num2 != 0) {
            int temp = num1;
            num1 = num2;
            num2 = temp % num2;
        }
        return num1;
    }

    private static int BitCount(int i) {
        i = i - ((i >> 1) & 0x55555555);
        i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
        i = (i + (i >> 4)) & 0x0f0f0f0f;
        i = i + (i >> 8);
        i = i + (i >> 16);
        return i & 0x3f;
    }
}