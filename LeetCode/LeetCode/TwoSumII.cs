using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] returnValue = new int[2];

            int left, right,tempSum;

            left = 0;
            right = numbers.Length - 1;

            while (left < right)
            {
                tempSum = numbers[left] + numbers[right];
                if (tempSum == target)
                {
                    returnValue[0] = left + 1;
                    returnValue[1] = right + 1;
                    break;
                }
                else if (tempSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }

            return returnValue;

        }
    }
}
