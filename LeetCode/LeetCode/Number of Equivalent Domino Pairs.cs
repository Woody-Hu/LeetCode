using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Number_of_Equivalent_Domino_Pairs
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var dict = new Dictionary<int, int>();
            var res = 0;
            for (int i = 0; i < dominoes.GetLength(0); i++)
            {
                var value = Math.Min(dominoes[i][0], dominoes[i][1]) * 10 + Math.Max(dominoes[i][0], dominoes[i][1]);
                dict[value] = dict.GetValueOrDefault(value) + 1;
            }

            foreach (var onePair in dict)
            {
                res += onePair.Value * (onePair.Value - 1) / 2;
            }

            return res;
        }
    }
}
