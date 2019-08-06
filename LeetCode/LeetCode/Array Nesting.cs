using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Array_Nesting
    {
        public int ArrayNesting(int[] nums)
        {
            var res = int.MinValue;
            var visited = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var value = ArrayNesting(nums, nums[i], visited, 0);
                res = Math.Max(res, value);
            }

            return res;
        }

        private int ArrayNesting(int[] nums, int value, ISet<int> visited, int count)
        {
            if (visited.Contains(value))
            {
                return count;
            }

            visited.Add(value);
            return ArrayNesting(nums, nums[value], visited, count + 1);

        }
    }
}
