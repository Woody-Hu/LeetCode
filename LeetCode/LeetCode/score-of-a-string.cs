using System;

namespace LeetCode;

public class score_of_a_string
{
    public int ScoreOfString(string s)
    {
        var res = 0;
        for (var i = 1; i < s.Length; i++)
        {
            res += Math.Abs(s[i] - s[i - 1]);
        }

        return res;
    }
}