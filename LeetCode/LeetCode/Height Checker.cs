using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Height_Checker
    {
        public int HeightChecker(int[] heights)
        {
            var copiedArray = new int[heights.Length];
            Array.Copy(heights, copiedArray, heights.Length);
            Array.Sort(copiedArray);
            var count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != copiedArray[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
