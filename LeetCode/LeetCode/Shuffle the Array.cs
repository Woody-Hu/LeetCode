using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Shuffle_the_Array
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var res = new int[2 * n];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    res[i] = nums[i / 2];
                }
                else
                {
                    res[i] = nums[n + i / 2];
                }
            }

            return res;
        }
    }
}
