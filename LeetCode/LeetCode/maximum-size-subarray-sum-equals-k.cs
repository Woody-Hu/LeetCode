using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_size_subarray_sum_equals_k
    {
        public int MaxSubArrayLen(int[] nums, int k)
        {
            var sumDic = new Dictionary<int, int>();
            sumDic.Add(0, -1);
            var sum = 0;
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (!sumDic.ContainsKey(sum))
                {
                    sumDic[sum] = i;
                }

                if (sumDic.ContainsKey(sum - k))
                {
                    res = Math.Max(res, i - sumDic[sum - k]);
                }
            }

            return res;
        }
    }
}
