using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class find_triangular_sum_of_an_array
    {
        public int TriangularSum(int[] nums)
        {
            while (nums.Count() > 1)
            {
                var newArray = new int[nums.Count() - 1];
                var j = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    newArray[j++] = (nums[i - 1] + nums[i]) % 10;
                }

                nums = newArray;
            }

            return nums[0];
        }
    }
}
