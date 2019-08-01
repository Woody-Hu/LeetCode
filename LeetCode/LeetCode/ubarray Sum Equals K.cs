using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ubarray_Sum_Equals_K
    {
        public int SubarraySum(int[] nums, int k)
        {
            var dict = new Dictionary<int,int>();
            var sum = 0;
            var res = 0;
            dict.Add(0,1);

            foreach (var oneValue in nums)
            {
                sum += oneValue;
                if (dict.ContainsKey(sum - k))
                {
                    res += dict[sum - k];
                }

                dict[sum] = dict.GetValueOrDefault(sum) + 1;
            }

            return res;
        }
    }
}
