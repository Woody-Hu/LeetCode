using System;
namespace LeetCode
{
	public class find_the_score_of_all_prefixes_of_an_arra
	{
        public long[] FindPrefixScore(int[] nums)
        {
            var len = nums.Length;
            var arr = new long[len];
            var max = 0;
            for (int i = 0; i < len; i++)
            {
                max = Math.Max(max, nums[i]);
                arr[i] = nums[i] + max;
            }

            var res = new long[len];
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    res[i] = arr[i];
                }
                else
                {
                    res[i] = arr[i] + res[i - 1];
                }

            }

            return res;
        }
    }
}

