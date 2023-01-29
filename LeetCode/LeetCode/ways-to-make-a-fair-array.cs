using System;
namespace LeetCode
{
    public class ways_to_make_a_fair_array
    {
        public int WaysToMakeFair(int[] nums)
        {
            var odd1 = 0;
            var even1 = 0;
            var odd2 = 0;
            var even2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i & 1) != 0)
                {
                    odd1 += nums[i];
                }
                else
                {
                    even1 += nums[i];
                }
            }

            var res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i & 1) != 0)
                {
                    odd1 -= nums[i];
                }
                else
                {
                    even1 -= nums[i];
                }

                if (even1 + odd2 == odd1 + even2)
                {
                    res++;
                }

                if ((i & 1) != 0)
                {
                    odd2 += nums[i];
                }
                else
                {
                    even2 += nums[i];
                }
            }

            return res;
        }
    }
}
