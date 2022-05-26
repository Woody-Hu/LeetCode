using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_length_of_pair_chain
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, new InnerComarper());
            var res = 0;
            var pre = int.MinValue;
            foreach (var item in pairs)
            {
                if (item[0] > pre)
                {
                    res++;
                    pre = item[1];
                }
            }

            return res;
        }

        private sealed class InnerComarper : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[1] - y[1];
            }
        }
    }
}
