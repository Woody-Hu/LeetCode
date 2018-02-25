using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            int[] freq = new int[26];
            for (int i = 0; i < s.Length; i++)
                freq[s[i] - 'a']++;
            for (int i = 0; i < s.Length; i++)
                if (freq[s[i] - 'a'] == 1)
                    return i;
            return -1;
        }
    }
}
