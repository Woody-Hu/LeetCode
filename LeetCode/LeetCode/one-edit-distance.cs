using System;
namespace LeetCode
{
    public class one_edit_distance
    {
        public bool IsOneEditDistance(string s, string t)
        {
            var ls = s.Length;
            var lt = s.Length;
            if (ls > lt)
            {
                return IsOneEditDistance(t, s);
            }

            if (lt - ls > 1)
            {
                return false;
            }

            for (int i = 0; i < ls; i++)
            {
                if (s[i] != t[i])
                {
                    if (ls == lt)
                    {
                        return s.Substring(i + 1, s.Length - i - 1).Equals(t.Substring(i + 1, t.Length - i - 1));
                    }
                    else
                    {
                        return s.Substring(i, s.Length - i).Equals(t.Substring(i + 1, t.Length - i - 1));
                    }
                }
            }

            return ls + 1 == lt;
        }
    }
}
