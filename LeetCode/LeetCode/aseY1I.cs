using System;

namespace LeetCode;

public class aseY1I
{
    public int MaxProduct(string[] words)
    {
        var n = words.Length;
        var masks = new int[n];
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            foreach (var c in word)
            {
                masks[i] |= 1 << (c - 'a');
            }
        }

        var res = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((masks[i] & masks[j]) == 0)
                {
                    res = Math.Max(res, words[i].Length * words[j].Length);
                }
            }
        }

        return res;
    }



}