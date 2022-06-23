using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class loud_and_rich
    {
        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            var g = new List<int>[quiet.Length];
            for (int i = 0; i < quiet.Length; i++)
            {
                g[i] = new List<int>();
            }

            foreach (var item in richer)
            {
                g[item[1]].Add(item[0]);
            }

            var res = new int[quiet.Length];
            for (int i = 0; i < quiet.Length; i++)
            {
                res[i] = -1;
            }

            for (int i = 0; i < quiet.Length; i++)
            {
                Visit(g, res, i, quiet);
            }

            return res;
        }

        private void Visit(List<int>[] g, int[] res, int i, int[] quiet)
        {
            if (res[i] != -1)
            {
                return;
            }

            res[i] = i;
            foreach (var item in g[i])
            {
                Visit(g, res, item, quiet);
                if (quiet[res[item]] < quiet[res[i]])
                {
                    res[i] = res[item];
                }
            }
        }
    }
}
