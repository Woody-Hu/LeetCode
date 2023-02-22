using System;
namespace LeetCode
{
	public class minimum_score_triangulation_of_polygon
	{
        public int MinScoreTriangulation(int[] values)
        {
            if (values == null || values.Length <= 0)
            {
                return 0;
            }

            var n = values.Length;
            var dp = new int[n, n];
            for (int len = 3; len <= n; len++)
            {
                for (int left = 0; left <= n - len; left++)
                {
                    var right = left + len - 1;
                    dp[left, right] = int.MaxValue;
                    for (int i = left + 1; i < right; i++)
                        dp[left,right] = Math.Min(dp[left,right], dp[left,i] + dp[i,right] + values[i] * values[left] * values[right]);
                    
                }
            }

            return dp[0, n - 1];

        }
    }
}

