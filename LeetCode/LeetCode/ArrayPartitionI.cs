using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ArrayPartitionI
    {
        public class Solution
        {
            public int ArrayPairSum(int[] nums)
            {
                var tempNums = nums.ToList();

                tempNums.Sort();

                int returnValue = 0;

                int sumCount = tempNums.Count();

                for (int i = 0; i < sumCount; i = i +2)
                {
                    returnValue += tempNums.ElementAt(i);
                }

                return returnValue;
            }
        }
    }
}
