using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Shuffle_String
    {
        public string RestoreString(string s, int[] indices)
        {
            var length = s.Length;
            char[] res = new char[length];

            for (int i = 0; i < length; i++)
            {
                res[indices[i]] = s[i];
            }

            return new string(res);
        }
    }
}
