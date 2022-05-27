using System;
namespace LeetCode
{
    public class redundant_connection
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            var n = edges.Length;
            var parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            foreach (var item in edges)
            {
                var x = item[0] - 1;
                var y = item[1] - 1;
                if (Find(parents, x) != Find(parents, y))
                {
                    Merge(parents, x, y);
                }
                else
                {
                    return item;
                }
            }

            return new int[2];
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

        private void Merge(int[] parents, int left, int right)
        {
            var x = left;
            var y = right;
            if (left > right)
            {
                x = right;
                y = left;
            }

            parents[Find(parents, y)] = Find(parents, x);
        }
    }
}
