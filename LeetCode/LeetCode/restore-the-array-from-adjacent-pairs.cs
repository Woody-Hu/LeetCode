using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class restore_the_array_from_adjacent_pairs
    {
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var dic = new Dictionary<int, List<int>>();
            foreach (var item in adjacentPairs)
            {
                if (!dic.ContainsKey(item[0]))
                {
                    dic.Add(item[0], new List<int>());
                }

                if (!dic.ContainsKey(item[1]))
                {
                    dic.Add(item[1], new List<int>());
                }

                dic[item[0]].Add(item[1]);
                dic[item[1]].Add(item[0]);
            }

            var res = new int[adjacentPairs.Length + 1];
            foreach (var item in dic)
            {
                if (item.Value.Count == 1)
                {
                    res[0] = item.Key;
                    break;
                }
            }

            res[1] = dic[res[0]][0];
            for (int i = 2; i < res.Length; i++)
            {
                var pre = res[i - 1];
                var list = dic[pre];
                res[i] = res[i - 2] == list[0] ? list[1] : list[0];
            }

            return res;
        }
    }
}
