using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Single_Number_III
    {
        public int[] SingleNumber(int[] nums)
        {
            var xorResult = 0;
            foreach (var value in nums)
            {
                xorResult ^= value;
            }

            xorResult &= -xorResult;
            var returnValue = new int[2];
            foreach (var value in nums)
            {
                if ((xorResult & value) == 0)
                {
                    returnValue[0] ^= value;
                }
                else
                {
                    returnValue[1] ^= value;
                }
            }

            return returnValue;
        }
    }
}
