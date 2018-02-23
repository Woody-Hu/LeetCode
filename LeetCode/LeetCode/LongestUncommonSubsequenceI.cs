using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestUncommonSubsequenceI
    {
        public int FindLUSlength(string a, string b)
        {
            return a.Equals(b) ? -1 : Math.Max(a.Length, b.Length);
        }
    }
}
