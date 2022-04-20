using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class top_k_frequent_words
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            var ordered = dict.OrderByDescending(k => k.Value).ThenBy(k => k.Key);
            var res = new List<string>();
            foreach (var item in ordered)
            {
                if (k <= 0)
                {
                    break;
                }

                res.Add(item.Key);
                k--;
            }

            return res;
        
        }
    }
}
