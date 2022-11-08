using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ambiguous_coordinates
    {
        public IList<string> AmbiguousCoordinates(string s)
        {
            var n = s.Length - 2;
            var res = new List<string>();
            s = s.Substring(1, s.Length - 2);
            for (int i = 1; i < n; i++)
            {
                var l = GetPos(s.Substring(0, i));
                if (l.Count == 0)
                {
                    continue;
                }

                var r = GetPos(s.Substring(i));
                if (r.Count == 0)
                {
                    continue;
                }

                foreach (var li in l)
                {
                    foreach (var ri in r)
                    {
                        res.Add($"({li}, {ri})");
                    }
                }
            }

            return res;
        }

        private List<string> GetPos(string s)
        {
            var pos = new List<string>();
            if (s[0] != '0' || "0".Equals(s))
            {
                pos.Add(s);
            }

            for (int i = 1; i < s.Length; i++)
            {
                if ((i != 1 && s[0] == '0') || s[s.Length - 1] == '0')
                {
                    continue;
                }
                pos.Add(s.Substring(0, i) + "." + s.Substring(i));
            }

            return pos;
        }
    }
}

