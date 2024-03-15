using System.Collections.Generic;

namespace LeetCode;

public class kth_distinct_string_in_an_array
{
    public string KthDistinct(string[] arr, int k)
    {
        var dict = new Dictionary<string, int>();
        foreach (var s in arr)
        {
            if (!dict.TryAdd(s, 1))
            {
                dict[s]++;
            }
        }
        
        var i = 0;
        foreach (var (key, value) in dict)
        {
            if (value == 1)
            {
                i++;
                if (i == k)
                {
                    return key;
                }
            }
        }

        return "";
    }
}