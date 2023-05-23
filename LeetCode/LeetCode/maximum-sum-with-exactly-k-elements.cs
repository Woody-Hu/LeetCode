using System;
using System.Linq;

namespace LeetCode
{
    public class maximum_sum_with_exactly_k_elements
    {
        public int MaximizeSum(int[] nums, int k)
        {
            var max = nums.Max();
            return (2 * max + k - 1) * k / 2;
        }
    }
}
