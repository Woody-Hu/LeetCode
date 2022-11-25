using System;
namespace LeetCode
{
    public class largest_combination_with_bitwise_and_greater_than_zero
    {
        public int LargestCombination(int[] candidates)
        {
            var array = new int[32];
            var res = 0;
            foreach (var item in candidates)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (((1<<i)&item) > 0)
                    {
                        array[i]++;
                    }
                }
            }

            foreach (var item in array)
            {
                res = Math.Max(res, item);
            }

            return res;
        }
    }
}
