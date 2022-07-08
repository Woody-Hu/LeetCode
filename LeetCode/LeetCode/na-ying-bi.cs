using System;
using System.Linq;

namespace LeetCode
{
    public class na_ying_bi
    {
        public int MinCount(int[] coins)
        {
            return coins.Sum(k => (k + 1) / 2);
        }
    }
}
