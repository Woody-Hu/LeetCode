using System;
using System.Collections.Generic;

namespace LeetCode;

public class group_anagrams_lcci
{
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
        foreach (string str in strs) {
            char[] array = str.ToCharArray();
            Array.Sort(array);
            string key = new string(array);
            if (dictionary.ContainsKey(key)) {
                dictionary[key].Add(str);
            } else {
                IList<string> list = new List<string>{str};
                dictionary.Add(key, list);
            }
        }
        return new List<IList<string>>(dictionary.Values);
    }
}