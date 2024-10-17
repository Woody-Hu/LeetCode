using System;
using System.Text;

namespace LeetCode;

public class divide_a_string_into_groups_of_size_k
{
    public string[] DivideString(string s, int k, char fill)
    {
        var n = s.Length;
        var groups = (n - 1) / k + 1;
        var res = new string[groups];
        for (var i = 0; i < groups; i++)
        {
            var start = i * k;
            var end = Math.Min(start + k, n);
            var sb = new StringBuilder(s.Substring(start, end - start + 1));
            while (sb.Length < k) {
                sb.Append(fill);
            }
            
            res[i] = sb.ToString();
        }

        return res;
    }
}