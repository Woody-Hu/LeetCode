using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximum_Product_of_Two_Elements_in_an_Array
    {
        public int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
        }
    }
}
