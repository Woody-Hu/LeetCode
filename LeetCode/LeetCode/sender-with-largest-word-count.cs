using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class sender_with_largest_word_count
	{
        public string LargestWordCount(string[] messages, string[] senders)
        {
            var res = string.Empty;
            var max = 0;
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < messages.Length; i++)
            {
                var num = messages[i].Split(' ').Length;
                if (!dic.ContainsKey(senders[i])) dic.Add(senders[i], num);
                else dic[senders[i]] += num;

                if (dic[senders[i]] > max || (dic[senders[i]] == max && StringComparer.Ordinal.Compare(senders[i], res) > 0))
                {
                    max = dic[senders[i]];
                    res = senders[i];
                }
            }

            return res;
        }
    }
}

