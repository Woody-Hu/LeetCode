using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Number_of_Good_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                dict[item] = dict.GetValueOrDefault(item) + 1;
            }

            var res = 0;
            foreach (var onePair in dict)
            {
                var temp = (onePair.Value) * (onePair.Value - 1) / 2;
                if (temp > 0)
                {
                    res += temp;
                }
            }

            return res;
        }
    }
}
