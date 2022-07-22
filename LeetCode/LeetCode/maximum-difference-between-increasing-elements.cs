using System;
namespace LeetCode
{
    public class maximum_difference_between_increasing_elements
    {
        public int MaximumDifference(int[] nums)
        {
            var res = -1;
            var pre = nums[0];
            foreach (var item in nums)
            {
                if (item > pre)
                {
                    res = Math.Max(item - pre, res);
                }
                else
                {
                    pre = item;
                }
            }

            return res;
        }
    }
}
