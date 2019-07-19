using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Beautiful_Arrangement
    {
        public int CountArrangement(int N)
        {
            var res = 0;
            var visitedSet = new HashSet<int>();
            var currentPosition = 1;
            CountArrangement(N, visitedSet, 1, ref res);
            return res;
        }

        private void CountArrangement(int n, HashSet<int> visitedSet, int currentPosition, ref int res)
        {
            if (currentPosition > n)
            {
                res++;
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visitedSet.Contains(i))
                {
                    if (i % currentPosition != 0 && currentPosition % i != 0) continue;
                    visitedSet.Add(i);
                    CountArrangement(n, visitedSet, currentPosition + 1, ref res);
                    visitedSet.Remove(i);
                }
            }
        }
    }
}
