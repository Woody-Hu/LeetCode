using System;
namespace LeetCode
{
	public class semi_ordered_permutation
	{
        public int SemiOrderedPermutation(int[] nums)
        {
            var len = nums.Length;
            var head = -1;
            var tail = -1;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 1)
                {
                    head = i;
                }
                else if (nums[i] == len)
                {
                    tail = i;
                }
            }

            var res = head + (len - 1 - tail);
            if (head > tail)
            {
                res--;
            }

            return res;
        }
    }
}

