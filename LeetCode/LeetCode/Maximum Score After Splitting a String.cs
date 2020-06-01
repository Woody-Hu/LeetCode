using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximum_Score_After_Splitting_a_String
    {
        public int MaxScore(string s)
        {
            int left = 0;
            int right = 0;
            int total = 0;
            if (s.Length == 0) return total;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1') right++;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0') left++;
                if (s[i] == '1') right--;
                total = Math.Max(total, left + right);
            }

            return total;
        }
    }
}
