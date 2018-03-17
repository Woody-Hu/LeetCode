using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (null == nums || 0 == nums.Length)
            {
                return 0;
            }

            if (1 == nums.Length)
            {
                return nums[0];
            }

            int useLength = nums.Length;

            int[] anotherNum = new int[nums.Length - 1];
            int[] anotherNum2 = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                anotherNum[i] = nums[i];
                anotherNum2[i] = nums[i + 1];
            }

            return Math.Max(InOneDirection(anotherNum, useLength - 1), InOneDirection(anotherNum2, useLength -1));
        }

        private int InOneDirection(int[] nums ,int inputLength)
        {
            if (1 == inputLength)
            {
                return nums[0];
            }

            int useLength = inputLength;

            int[] maxValue = new int[useLength];

            maxValue[0] = nums[0];

            maxValue[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < useLength; i++)
            {
                maxValue[i] = Math.Max(maxValue[i - 1], maxValue[i - 2] + nums[i]);
            }

            return maxValue[useLength - 1];
        }
    }
}
