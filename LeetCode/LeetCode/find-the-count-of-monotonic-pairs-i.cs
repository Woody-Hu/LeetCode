namespace LeetCode;

public class find_the_count_of_monotonic_pairs_i
{
    public int CountOfPairs(int[] nums)
    {
        var n = nums.Length;
        var dp = new int[n, 51];
        var mod = 1000000007;
        for (var v = 0; v <= nums[0]; v++) {
            dp[0, v] = 1;
        }

        for (var i = 1; i < n; i++)
        {
            for (var v2 = 0; v2 <= nums[i]; v2++) {
                for (var v1 = 0; v1 <= v2; v1++) {
                    if (nums[i - 1] - v1 >= nums[i] - v2) {
                        dp[i, v2] = (dp[i, v2] + dp[i - 1, v1]) % mod;
                    }
                }
            }
        }
        
        var res = 0;
        for (var v = 0; v < 51; v++) {
            res = (res + dp[n - 1, v]) % mod;
        }
        
        return res;
    }
}