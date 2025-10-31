using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximum_alternating_sum_of_squares
    {
        public long MaxAlternatingSum(int[] nums)
        {
            int n = nums.Length;
            int[] squares = new int[n];
            for (int i = 0; i < n; i++)
            {
                squares[i] = nums[i] * nums[i];
            }
            Array.Sort(squares);
            long sum = 0;
            int negativeCount = n / 2;
            for (int i = 0; i < n; i++)
            {
                if (i < negativeCount)
                {
                    sum -= squares[i];
                }
                else
                {
                    sum += squares[i];
                }
            }
            return sum;

        }
    }
}
