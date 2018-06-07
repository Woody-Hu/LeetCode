using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length < 2)
            {
                return -1;
            }

            int tempSum = nums.Sum();

            int nowLeftValue = 0;

            int nowRightValue = tempSum - nums[0];

            if (nowLeftValue == nowRightValue)
            {
                return 0;
            }

            for (int i = 1; i < nums.Length ; i++)
            {
                nowLeftValue = nowLeftValue + nums[i - 1];

                nowRightValue = nowRightValue - nums[i];

                if (nowLeftValue == nowRightValue)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
