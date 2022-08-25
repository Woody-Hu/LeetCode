using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class all_divisions_with_the_highest_score_of_a_binary_array
    {
        public IList<int> MaxScoreIndices(int[] nums)
        {
            var n = nums.Length;
            var preSum = 0;
            var best = 0;
            var res = new List<int>() { 0};
            for (int i = 0; i < n; i++)
            {
                var item = nums[i];
                if (item == 0)
                {
                    preSum++;
                    if (preSum > best)
                    {
                        best = preSum;
                        res = new List<int>() { i + 1 };
                    }
                    else if (preSum == best)
                    {
                        res.Add(i + 1);
                    }
                }
                else
                {
                    preSum--;
                }
            }

            return res;
        }
    }
}
