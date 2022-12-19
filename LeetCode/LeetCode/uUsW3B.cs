using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class uUsW3B
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var list = new List<int>();
            var res = new List<IList<int>>();
            DFS(1, n, k, list, res);
            return res;
        }

        private void DFS(int current, int n, int k, List<int> list, List<IList<int>> res)
        {
            if (list.Count + (n - current + 1) < k)
            {
                return;
            }

            if (list.Count == k)
            {
                res.Add(new List<int>(list));
                return;
            }

            list.Add(current);
            DFS(current + 1, n, k, list, res);
            list.RemoveAt(list.Count - 1);
            DFS(current + 1, n, k, list, res);
        }
    }
}
