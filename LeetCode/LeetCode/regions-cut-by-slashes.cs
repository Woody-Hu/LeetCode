using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class regions_cut_by_slashes
    {
        public int RegionsBySlashes(string[] grid)
        {
            int n = grid.Length;
            var f = new int[n * n * 4];
            for (int i = 0; i < n * n * 4; i++)
            {
                f[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int idx = i * n + j;
                    if (i < n - 1)
                    {
                        int bottom = idx + n;
                        Merge(f, idx * 4 + 2, bottom * 4);
                    }

                    if (j < n - 1)
                    {
                        int right = idx + 1;
                        Merge(f, idx * 4 + 1, right * 4 + 3);
                    }

                    if (grid[i][j] == '/')
                    {
                        Merge(f, idx * 4, idx * 4 + 3);
                        Merge(f, idx * 4 + 1, idx * 4 + 2);
                    }
                    else if (grid[i][j] == '\\')
                    {
                        Merge(f, idx * 4, idx * 4 + 1);
                        Merge(f, idx * 4 + 2, idx * 4 + 3);
                    }
                    else
                    {
                        Merge(f, idx * 4, idx * 4 + 1);
                        Merge(f, idx * 4 + 1, idx * 4 + 2);
                        Merge(f, idx * 4 + 2, idx * 4 + 3);
                    }
                }
            }

            var set = new HashSet<int>();
            for (int i = 0; i < n * n * 4; i++)
            {
                set.Add(Find(f, i));
            }

            return set.Count;
        }

        private int Find(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return parents[i];
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
