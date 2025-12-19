using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class absolute_difference_between_maximum_and_minimum_k_elements
    {
        public int AbsDifference(int[] nums, int k)
        {
            int difference = 0;
            Array.Sort(nums);
            int n = nums.Length;
            for (int i = n - 1, j = k - 1; j >= 0; i--, j--)
            {
                difference += nums[i];
                difference -= nums[j];
            }

            return difference;
        }
    }
}
