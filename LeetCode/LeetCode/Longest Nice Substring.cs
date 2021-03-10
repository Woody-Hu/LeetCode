using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Longest_Nice_Substring
    {
        public string LongestNiceSubstring(string s)
        {
            var answer = string.Empty;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (IsNiceString(s, i, j- i + 1) && answer.Count() < (j-i+1))
                    {
                        answer = s.Substring(i, j-i+1);
                    }
                }
            }

            return answer;
        }

        public bool IsNiceString(string s, int start, int end)
        {
            var bitArray = new BitArray(52, false);
            var bitArray2 = new BitArray(52, false);
            for (int i = start; i < end; i++)
            {
                var baseIndex = char.IsLower(s[i]) ? 0 : 26;
                var offset = char.ToLower(s[i]) - 'a';
                var index = baseIndex + offset;
                bitArray[index] = bitArray[index] | true;
                bitArray2[offset] = bitArray2[offset] | true;
                bitArray2[26 + offset] = bitArray2[26 + offset] | true;
            }

            var xorRes = bitArray2.Xor(bitArray);
            for (int i = 0; i < 52; i++)
            {
                if (xorRes.Get(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
