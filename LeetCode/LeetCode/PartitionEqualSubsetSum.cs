using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            if (nums.Count() < 2)
            {
                return false;
            }

            nums = nums.OrderBy(k => k).ToArray();

            int sum = nums.Sum();

            if (sum %2 != 0)
            {
                return false;
            }

            return InnerMethod(nums, sum, 0, 0);
        }

        private bool InnerMethod(int[] inputNums,int inputSum,int nowValue,int nowIndex)
        {
            for (int i = nowIndex; i < inputNums.Length; i++)
            {
                if (i > nowIndex && inputNums[i]==inputNums[i-1])
                {
                    continue;
                }
                else if (inputSum - inputNums[i] < nowValue + inputNums[i])
                {
                    break;
                }
                else if (inputNums[i] > inputSum/2 )
                {
                    break;
                }
                else if ((inputSum - inputNums[i] == nowValue + inputNums[i])||( InnerMethod(inputNums,inputSum-inputNums[i],nowValue +inputNums[i],i + 1)) )
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
