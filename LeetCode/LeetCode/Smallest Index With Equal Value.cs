using System;
namespace LeetCode
{
    public class Smallest_Index_With_Equal_Value
    {
        public int SmallestEqual(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
