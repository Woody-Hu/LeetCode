using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int minLength = int.MaxValue;
            int useLength = nums.Length;
            int useIndex = 0;
            int useStartIndex = useIndex;
            int nowSumValue = 0;

            while (useIndex < useLength)
            {
                while(nowSumValue < s)
                {
                    nowSumValue += nums[useIndex];
                    useIndex++;
                    if (useIndex == useLength)
                    {
                        break;
                    }
                }
                while (nowSumValue >= s)
                {
                    minLength = Math.Min(minLength, useIndex - useStartIndex);
                    nowSumValue -= nums[useStartIndex];
                    useStartIndex++;
                }

            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
