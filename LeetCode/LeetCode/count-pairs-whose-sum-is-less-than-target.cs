using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_pairs_whose_sum_is_less_than_target
	{
        public int CountPairs(IList<int> nums, int target)
        {
            var res = 0;
            var list = new List<int>(nums);
            list.Sort();
            var left = 0;
            var right = list.Count - 1;
            while (left < right)
            {
                if (list[left] + list[right] < target)
                {
                    res += right - left;
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return res;
        }
    }
}

