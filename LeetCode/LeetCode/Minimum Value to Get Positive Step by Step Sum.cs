using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Value_to_Get_Positive_Step_by_Step_Sum
    {
        public int MinStartValue(int[] nums)
        {
            var min = int.MaxValue;
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
                min = Math.Min(min, sum);
            }

            if (min > 0)
            {
                return 1;
            }

            return -min + 1;
        }
    }
}
