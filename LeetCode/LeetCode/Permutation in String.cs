using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Permutation_in_String
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var array = new int[256];
            foreach (var oneChar in s1)
            {
                array[oneChar]++;
            }

            for (int count = 0, i = 0, j = -1 ; i < s2.Length; i++)
            {
                if (array[s2[i]]--> 0)
                {
                    count++;
                }

                if (i-j > s1.Length)
                {
                    if (++array[s2[j++]] > 0)
                    {
                        count--;
                    }
                }

                if (count == s1.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
