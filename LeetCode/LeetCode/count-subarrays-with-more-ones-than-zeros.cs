using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class count_subarrays_with_more_ones_than_zeros
    {
        public int SubarraysWithMoreZerosThanOnes(int[] nums)
        {
            var mod = 1000000007;
            var res = 0;
            var sumDic = new Dictionary<int, int>();
            sumDic.Add(0, 1);
            var currentSum = 0;
            var lessThanSumCount = 0;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    currentSum--;
                    lessThanSumCount -= sumDic.GetValueOrDefault(currentSum, 0);
                }
                else
                {
                    lessThanSumCount += sumDic.GetValueOrDefault(currentSum, 0);
                    currentSum++;
                }

                if (!sumDic.ContainsKey(currentSum))
                {
                    sumDic.Add(currentSum, 0);
                }

                sumDic[currentSum]++;
                res = (res + lessThanSumCount) % mod;
            }

            return res;
        }
    }
}
