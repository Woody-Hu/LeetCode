using System;

namespace LeetCode;

public class lexicographically_smallest_string_after_operations_with_constraint
{
    public string GetSmallestString(string s, int k)
    {
        var arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            var dis = Math.Min(arr[i] - 'a', 'z' - arr[i] + 1);
            if (dis > k)
            {
                arr[i] = (char)(arr[i] - k);
                break;
            }
            else
            {
                arr[i] = 'a';
                k -= dis;
            }
        }

        return new string(arr);

    }
}