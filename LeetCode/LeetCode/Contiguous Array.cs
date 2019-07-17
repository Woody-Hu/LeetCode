using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Contiguous_Array
    {
        public int FindMaxLength(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            dict.Add(0,-1);
            var sum = 0;
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? -1 : nums[i];
                if (dict.ContainsKey(sum))
                {
                    res = Math.Max(res, i- dict[sum]);
                }
                else
                {
                    dict.Add(sum,res - i);
                }
            }

            return res;
        }
    }
}
