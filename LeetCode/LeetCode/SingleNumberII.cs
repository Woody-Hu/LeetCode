using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            var firstValue = 0;
            var secondValue = 0;

            foreach (var oneValue in nums)
            {
                firstValue = firstValue ^ oneValue & ~secondValue;
                secondValue = secondValue ^ oneValue & ~firstValue;
            }

            return firstValue;

        }
    }
}
