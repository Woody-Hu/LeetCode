using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TargetSum
    {
        public int FindTargetSumWays(int[] nums, int S)
        {
            int returnValue = 0;
            int useLength = nums.Length;
            int[] useSumValue = new int[useLength];
            useSumValue[useLength - 1] = nums[useLength - 1];

            for (int i = useLength - 2; i >=0; i--)
            {
                useSumValue[i] = useSumValue[i + 1] + nums[i];
            }

            InnerMethod(nums,useSumValue,S,0,ref returnValue);

            return returnValue;
        }

        private void InnerMethod(int[] inputNums,int[] inputSumValue,int wantValue,int useIndex,ref int returnValue)
        {
            if (useIndex == inputNums.Length)
            {
                if (0 == wantValue)
                {
                    returnValue++;
                 
                }
                return;
            }
         

            if (inputSumValue[useIndex] < Math.Abs(wantValue))
            {
                return;
            }

            InnerMethod(inputNums, inputSumValue, wantValue + inputNums[useIndex], useIndex + 1, ref returnValue);

            InnerMethod(inputNums, inputSumValue, wantValue - inputNums[useIndex], useIndex + 1, ref returnValue);
        }
    }
}
