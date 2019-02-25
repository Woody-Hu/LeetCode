using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_the_Town_Judge
    {
        public int FindJudge(int N, int[][] trust)
        {
            var array = new int[N + 1];

            foreach (var onePair in trust)
            {
                array[onePair[0]]--;
                array[onePair[1]]++;
            }

            for (int i = 1; i <= N; ++i)
            {
                if (array[i] == N - 1) return i;
            }

            return -1;
        }
    }
}
