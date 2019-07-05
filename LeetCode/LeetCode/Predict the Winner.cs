using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Predict_the_Winner
    {
        public bool PredictTheWinner(int[] nums)
        {
            int len = nums.Length;
            int[,] dp = new int[len, len];
            for (int i = 0; i < len; i++)
                dp[i, i] = nums[i];
            for (int i = len - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < len; j++)
                {
                    dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
                }
            }
            return dp[0, len - 1] >= 0;
        }
    }
}
