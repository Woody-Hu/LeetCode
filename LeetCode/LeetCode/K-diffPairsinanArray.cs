using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class K_diffPairsinanArray
    {
        public int FindPairs(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k < 0) return 0;

            Dictionary<int, int> useDic = new Dictionary<int, int>();

            foreach (var oneValue in nums)
            {
                if (!useDic.ContainsKey(oneValue))
                {
                    useDic.Add(oneValue, 0);
                }
                useDic[oneValue]++;
            }

            int returnValue = 0;

            foreach (var oneValue in useDic)
            {
                if (k == 0)
                {
                    if (oneValue.Value > 1)
                    {
                        returnValue++;
                    }
                }
                else
                {
                    if (useDic.ContainsKey(oneValue.Key + k))
                    {
                        returnValue++;
                    }
                }
            }

            return returnValue;

        }
    }
}
