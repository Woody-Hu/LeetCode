using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximize_expression_of_three_elements
    {
        public int MaximizeExpressionOfThree(int[] nums)
        {
            Array.Sort(nums);
            var res = nums[nums.Length - 1] + nums[nums.Length - 2] - nums[0];
            return res;

        }
    }
}
