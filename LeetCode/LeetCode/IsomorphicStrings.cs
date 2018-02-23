using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (null == s && null == t)
            {
                return true;
            }

            if (null == s || null == t)
            {
                return false;
            }

            if (s.Length != t.Length)
            {
                return false;
            }

            List<char> lstS = new List<char>();
            List<char> lstT = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (lstS.Contains(s[i]) && lstT.Contains(t[i]))
                {
                    if (lstS.IndexOf(s[i]) != lstT.IndexOf(t[i]))
                    {
                        return false;
                    }
                }
                else if (!lstS.Contains(s[i]) && !lstT.Contains(t[i]))
                {
                    lstS.Add(s[i]);
                    lstT.Add(t[i]);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
