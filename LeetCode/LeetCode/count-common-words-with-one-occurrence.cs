using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_common_words_with_one_occurrence
	{
        public int CountWords(string[] words1, string[] words2)
        {
            var dic1 = new Dictionary<string, int>();
            var dic2 = new Dictionary<string, int>();
            foreach (var item in words1)
            {
                if (!dic1.ContainsKey(item))
                {
                    dic1.Add(item, 0);
                }

                dic1[item]++;
            }

            foreach (var item in words2)
            {
                if (!dic2.ContainsKey(item))
                {
                    dic2.Add(item, 0);
                }

                dic2[item]++;
            }

            var res = 0;
            foreach (var item in dic1)
            {
                if (item.Value != 1)
                {
                    continue;
                }

                if (dic2.TryGetValue(item.Key, out var dic2Value) && dic2Value == 1)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

