using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Partition_Array_Into_Three_Parts_With_Equal_Sum
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            var sum = A.Sum();
            if (sum % 3 != 0)
            {
                return false;
            }

            sum = sum / 3;
            var count = 0;
            var tempSum = 0;

            foreach (var value in A)
            {
                tempSum += value;
                if (tempSum == sum)
                {
                    tempSum = 0;
                    count++;
                }
            }

            return count >= 3;
        }
    }
}
