using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximum_substrings_with_distinct_start
    {
        public int MaxDistinct(string s)
        {
            bool[] vis = new bool[26];
            int ans = 0;
            foreach (char c in s)
            {
                int index = c - 'a';
                if (!vis[index])
                {
                    vis[index] = true;
                    ans++;
                }
            }
            return ans;
        }
    }
}
