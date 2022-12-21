using System;
using System.Linq;

namespace LeetCode
{
    public class minimum_limit_of_balls_in_a_bag
    {
        public int MinimumSize(int[] nums, int maxOperations)
        {
            var left = 0;
            var right = nums.Max();
            var res = 0;
            while (left <= right)
            {
                var y = (left + right) / 2;
                var count = 0l;
                foreach (var item in nums)
                {
                    count += (item - 1) / y;
                }

                if (count <= maxOperations)
                {
                    res = y;
                    right = y - 1;
                }
                else
                {
                    left = y + 1;
                }
            }

            return res;
        }
    }
}
