using System;
namespace LeetCode
{
    public class longest_subarray_of_1s_after_deleting_one_element
    {
        public int LongestSubarray(int[] nums)
        {
            var res = 0;
            var p0 = 0;
            var p1 = 0;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    p1 = p0;
                    p0 = 0;
                }
                else
                {
                    ++p0;
                    ++p1;
                }

                res = Math.Max(res, p1);
            }

            if (res == nums.Length)
            {
                res--;
            }

            return res;

            
        }
    }
}
