using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Create_Target_Array_in_the_Given_Order
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var res = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                for (int j = res.Length - 1; j >= index[i] + 1; j--)
                {
                    res[j] = res[j - 1];
                }

                res[index[i]] = nums[i];
            }

            return res;
        }
    }
}
