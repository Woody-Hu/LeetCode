using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class compute_alternating_sum
    {
        public int AlternatingSum(int[] nums)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += nums[i];
                }
                else
                {
                    oddSum += nums[i];
                }
            }
            return evenSum - oddSum;

        }
    }
}
