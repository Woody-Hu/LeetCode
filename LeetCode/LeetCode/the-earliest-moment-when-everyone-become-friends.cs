using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class the_earliest_moment_when_everyone_become_friends
	{
		public int EarliestAcq(int[][] logs, int n)
		{
            Array.Sort(logs, new ArrayComparer());
            var parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            var linkCount = 1;
            foreach (var item in logs)
            {
                var t = item[0];
                var a = item[1];
                var b = item[2];
                if (Find(parents, a) == Find(parents, b))
                {
                    continue;
                }
                else
                {
                    Merge(parents, a, b);
                    linkCount = linkCount + 1;
                }

                if (linkCount == n)
                {
                    return t;
                }
            }

            return -1;
		}

        private int Find(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                parents[i] = Find(parents, parents[i]);
                return parents[i];
            }
        }

        private void Merge(int[] parents, int i, int j)
        {
            var left = Math.Min(i, j);
            var right = Math.Max(i, j);
            parents[Find(parents, right)] = parents[Find(parents, left)];
        }


        private class ArrayComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] - y[0];
            }
        }
    }
}

