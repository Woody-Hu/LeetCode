using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class longest_string_chain
    {
        public int LongestStrChain(string[] words)
        {
            var dic = new Dictionary<string, int>();
            Array.Sort(words, (a, b) => a.Length - b.Length);
            var res = 0;
            foreach (var item in words)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] = 1;
                }
                else
                {
                    dic.Add(item, 1);
                }

                for (int i = 0; i < item.Length; i++)
                {
                    var ps = item.Substring(0, i) + item.Substring(i + 1);
                    if (dic.ContainsKey(ps))
                    {
                        dic[item] = Math.Max(dic[item], dic[ps] + 1);
                    }
                }

                res = Math.Max(res, dic[item]);
            }

            return res;
        }
    }
}
