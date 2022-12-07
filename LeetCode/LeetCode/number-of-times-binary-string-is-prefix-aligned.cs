using System;
namespace LeetCode
{
    public class number_of_times_binary_string_is_prefix_aligned
    {
        public int NumTimesAllBlue(int[] flips)
        {
            var res = 0;
            var max = 0;
            for (int i = 0; i < flips.Length; i++)
            {
                max = Math.Max(max, flips[i]);
                if (max == i + 1)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
