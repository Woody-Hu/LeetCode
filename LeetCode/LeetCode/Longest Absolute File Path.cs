using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Longest_Absolute_File_Path
    {
        public int LengthLongestPath(string input)
        {
            var strings = input.Split("\n");
            int[] array = new int[strings.Length + 1];
            var maxLength = 0;
            foreach (var oneStr in strings)
            {
                var degree = oneStr.LastIndexOf("\t") + 1;
                var currentLength = array[degree] + oneStr.Length - degree + 1;
                array[degree + 1] = currentLength;

                if (oneStr.Contains("."))
                {
                    maxLength = Math.Max(maxLength, currentLength - 1);
                }
            }

            return maxLength;
        }
    }
}
