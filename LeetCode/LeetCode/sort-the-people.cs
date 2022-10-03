using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class sort_the_people
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            var dict = new Dictionary<int, string>();
            for (int i = 0; i < heights.Length; i++)
            {
                dict.Add(heights[i], names[i]);
            }

            Array.Sort(heights);
            var res = new string[names.Length];
            var j = 0;
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                res[j++] = dict[heights[i]];
            }

            return res;
        }
    }
}

