using System;

namespace LeetCode;

public class minimum_time_to_type_word_using_special_typewriter
{
    public int MinTimeToType(string word)
    {
        var res = 0;
        var prev = 0;
        foreach (var c in word)
        {
            var cur = c - 'a';
            res += 1+  Math.Min(Math.Abs(cur - prev), 26 - Math.Abs(cur - prev));
            prev = cur;
        }

        return res;
    }
}