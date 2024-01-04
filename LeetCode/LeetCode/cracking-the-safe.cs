using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class cracking_the_safe
	{
        public string CrackSafe(int n, int k)
        {
            var visit = new HashSet<int>();
            var res = new StringBuilder();
            var highest = (int)Math.Pow(10, n - 1);
            DFS(0, k, highest, ref visit, ref res);
            for (int i = 1; i < n; i++)
            {
                res.Append('0');
            }

            return res.ToString();
            
        }

        private void DFS(int node, int k, int highest, ref HashSet<int> visit, ref StringBuilder res)
        {
            for (int x = 0; x < k; x++)
            {
                var nei = node * 10 + x;
                if (!visit.Contains(nei))
                {
                    visit.Add(nei);
                    DFS(nei % highest, k, highest, ref visit, ref res);
                    res.Append(x);    
                }
            }
        }
    }
}

