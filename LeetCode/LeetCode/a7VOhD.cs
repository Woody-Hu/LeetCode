using System;
namespace LeetCode
{
	public class a7VOhD
	{
        public int CountSubstrings(string s)
        {
            var n = s.Length;
            var res = 0;
            for (int i = 0; i < 2* n - 1; i++)
            {
                var l = i / 2;
                var r = i / 2 + i % 2;
                while (l >= 0 && r < n && s[l] == s[r])
                {
                    --l;
                    ++r;
                    ++res;
                }
            }

            return res;
        }
    }
}

