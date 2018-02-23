using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            char[] chars = s.OrderBy(c => c).ToArray();
            char[] chart = t.OrderBy(c => c).ToArray();
            if (new String(chars).Equals(new String(chart)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
