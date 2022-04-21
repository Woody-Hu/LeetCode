using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class reorganize_string
    {
        public string ReorganizeString(string s)
        {
            var dic = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }


            dic = dic.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, k => k.Value);
            var n = s.Length;
            if (dic.First().Value > ((n+1)/2))
            {
                return string.Empty;
            }

            var res = new char[n];
            for (int i = 0; i < n; i = i + 2)
            {
                Append(i, res, dic);
            }

            for (int i = 1; i < n; i = i + 2)
            {
                Append(i, res, dic);
            }

            return new string(res);
        }

        private void Append(int i, char[] array, Dictionary<char, int> dic)
        {
            var key = dic.First().Key;
            array[i] = key;
            dic[key]--;
            if (dic[key] <= 0)
            {
                dic.Remove(key);
            }
        }
    }
}
