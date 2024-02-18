using System;
namespace LeetCode
{
	public class number_of_subarrays_that_match_a_pattern_i
	{
        public int CountMatchingSubarrays(int[] nums, int[] pattern)
        {
            var m = pattern.Length;
            var pi = new int[m];
            var cnt = 0;
            for (int i = 1; i < m; i++)
            {
                var v = pattern[i];
                while (cnt > 0 && pattern[cnt] != v)
                {
                    cnt = pi[cnt - 1];
                }

                if (pattern[cnt] == v)
                {
                    cnt++;
                }

                pi[i] = cnt;
            }

            int ans = 0;
            cnt = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int v = nums[i].CompareTo(nums[i - 1]);
                while (cnt > 0 && pattern[cnt] != v)
                {
                    cnt = pi[cnt - 1];
                }
                if (pattern[cnt] == v)
                {
                    cnt++;
                }
                if (cnt == m)
                {
                    ans++;
                    cnt = pi[cnt - 1];
                }
            }

            return ans;
        }
    }
}

