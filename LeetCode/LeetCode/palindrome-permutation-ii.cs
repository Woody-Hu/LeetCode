using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class palindrome_permutation_ii
    {
        public IList<string> GeneratePalindromes(string s)
        {
            var counts = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!counts.ContainsKey(item))
                {
                    counts.Add(item, 0);
                }

                counts[item]++;
            }

            var res = new List<string>();
            if (counts.Where(k => k.Value % 2 !=0).Count() > 1)
            {
                return res;
            }

            var center = string.Empty;
            if (counts.Any(k => k.Value % 2 != 0))
            {
                center = counts.First(k => k.Value % 2 != 0).Key.ToString();
            }

            var keys = counts.Keys.ToList();
            var size = 0;
            foreach (var item in keys)
            {
                var currentCount = counts[item];
                var updatedCount = currentCount / 2;
                counts[item] = updatedCount;
                if (updatedCount <= 0)
                {
                    counts.Remove(item);
                    continue;
                }

                size += updatedCount;
            }

            var chars = new char[size];
            var index = 0;
            foreach (var item in counts)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    chars[index++] = item.Key;
                }
            }

            var used = new bool[size];
            VisitChars(res, chars, used, new StringBuilder(), center);
            return res;
        }

        private void VisitChars(IList<string> res, char[] chars, bool[] used, StringBuilder stringBuilder, string center)
        {
            if (stringBuilder.Length == chars.Length)
            {
                var current = stringBuilder.ToString();
                var revert = new string(current.Reverse().ToArray());
                res.Add($"{current}{center}{revert}");
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (i > 0 && chars[i] == chars[i - 1] && !used[i - 1])
                {
                    continue;
                }

                stringBuilder.Append(chars[i]);
                used[i] = true;
                VisitChars(res, chars, used, stringBuilder, center);
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                used[i] = false;
            }
        }
    }
}
