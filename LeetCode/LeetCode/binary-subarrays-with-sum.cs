using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class binary_subarrays_with_sum
	{
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            var sum = 0;
            var dic = new Dictionary<int, int>();
            var res = 0;
            foreach (var item in nums)
            {
                if (dic.ContainsKey(sum))
                {
                    dic[sum]++;
                }
                else
                {
                    dic.Add(sum, 1);
                }

                sum += item;
                int val = 0;
                dic.TryGetValue(sum - goal, out val);
                res += val;
            }

            return res;

        }
    }
}

