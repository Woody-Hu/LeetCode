using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if (1 == k)
            {
                return nums.Max();
            }

            if (nums.Length < k)
            {
                return 0;
            }

            var tempLength = nums.Length;

            int nowUseValue = 0;
            int nowUseSumValue = 0;

            for (int i = 0; i < tempLength; i++)
            {
                if (i < k - 1)
                {
                    nowUseValue += nums[i];
                }
                else if (i == k - 1)
                {
                    nowUseValue += nums[i];
                    nowUseSumValue = nowUseValue;

                }
                else
                {
                    nowUseValue = nowUseValue + nums[i] - nums[i - k];

                    nowUseSumValue = Math.Max(nowUseSumValue, nowUseValue);
                }
            }

            return (double)nowUseSumValue / (double)k;
        }
    }
}
