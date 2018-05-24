using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int length = nums.Length;
            int[] useArray = new int[length];

            int tempIndex = 0;

            foreach (var oneValue in nums)
            {
                useArray[oneValue-1]++;

                if (2 == useArray[oneValue - 1])
                {
                    tempIndex = oneValue;
                    break;
                }
            }

            int tempSum = nums.Sum() - tempIndex;

            int lostValue = length * (length + 1) / 2 - tempSum;

            return new int[] { tempIndex, lostValue };

        }

    }
}
