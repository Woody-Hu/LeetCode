using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_the_number_of_complete_components
	{
        public int CountCompleteComponents(int n, int[][] edges)
        {
            var g = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int>();
            }

            foreach (var item in edges)
            {
                var e1 = item[0];
                var e2 = item[1];
                g[e1].Add(e2);
                g[e2].Add(e1);
            }

            var res = 0;
            var visit = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (!visit[i])
                {
                    var vc = 0;
                    var ec = 0;
                    DFS(i, g, visit, ref vc, ref ec);
                    if (ec == (vc - 1)*vc)
                    {
                        res++;
                    }
                }
            }

            return res;
        }

        private void DFS(int i, List<int>[] g, bool[] visit, ref int vc, ref int ec)
        {
            visit[i] = true;
            vc++;
            ec += g[i].Count;
            foreach (var item in g[i])
            {
                if (!visit[item])
                {
                    DFS(item, g, visit, ref vc, ref ec);
                }
            }
        }
    }
}

