using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class FairCandySwap
    {
        public int[] FairCandySwapMethod(int[] A, int[] B)
        {
            int sumA = 0;
            int sumB = 0;

            sumA = A.Sum();

            sumB = B.Sum();

            int target = (sumA + sumB) / 2 - sumA;

            Dictionary<int, int> useDic = new Dictionary<int, int>();

            foreach (var oneValue in A)
            {
                if (!useDic.ContainsKey(oneValue + target))
                {
                    useDic.Add(oneValue + target, oneValue);
                }
            }

            foreach (var oneValue in B)
            {
                if (useDic.ContainsKey(oneValue))
                {
                    return new int[] { useDic[oneValue],oneValue };
                }
            }

            return new int[] { 0, 0 };

        }
    }
}
