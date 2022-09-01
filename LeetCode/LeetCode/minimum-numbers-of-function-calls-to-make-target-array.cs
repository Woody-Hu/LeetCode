using System;
namespace LeetCode
{
    public class minimum_numbers_of_function_calls_to_make_target_array
    {
        public int MinOperations(int[] nums)
        {
            var res = 0;
            var maxV = 0;
            foreach (var item in nums)
            {
                var cur = item;
                maxV = Math.Max(maxV, item);
                while (cur != 0)
                {
                    if ((cur & 1 ) != 0)
                    {
                        res++;
                    }

                    cur = cur / 2;
                }
            }

            if (maxV != 0)
            {
                while (maxV != 0)
                {
                    res++;
                    maxV >>= 1;
                }
                res--;
            }

            return res;
        }
    }
}
