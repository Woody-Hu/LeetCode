using System.Collections.Generic;

namespace LeetCode;

public class count_unique_characters_of_all_substrings_of_a_given_string
{
    public int UniqueLetterString(string s) {
        var dic = new Dictionary<char, List<int>>();
        var res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.ContainsKey(s[i]))
            {
                dic[s[i]] = new List<int>();
                dic[s[i]].Add(-1);
            }
            dic[s[i]].Add(i);
        }
        
        foreach (var item in dic)
        {
            var list = item.Value;
            list.Add(s.Length);
            for (int i = 1; i < item.Value.Count - 1; i++)
            {
                res += (item.Value[i] - item.Value[i - 1]) * (item.Value[i + 1] - item.Value[i]);
            }
        }

        return res;

    }
}