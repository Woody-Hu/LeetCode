using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Subsequence_in_Non_Increasing_Order
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            foreach (var oneNumber in nums)
            {
                sum += oneNumber;
            }

            var res = new List<int>();
            var temp = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res.Add(nums[i]);
                temp += nums[i];
                if (temp > sum - temp)
                {
                    break;
                }
            }

            return res;
        }
    }
}
