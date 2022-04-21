using System;
namespace LeetCode
{
    public class maximum_area_of_a_piece_of_cake_after_horizontal_and_vertical_cuts
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            int mod = 1000000007;
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);
            var maxH = 0;
            for (int i = 1; i < horizontalCuts.Length; i++)
            {
                maxH = Math.Max(horizontalCuts[i] - horizontalCuts[i - 1], maxH);
            }

            maxH = Math.Max(horizontalCuts[0] - 0, maxH);
            maxH = Math.Max(h - horizontalCuts[horizontalCuts.Length - 1], maxH);

            var maxV = 0;
            for (int i = 1; i < verticalCuts.Length; i++)
            {
                maxV = Math.Max(verticalCuts[i] - verticalCuts[i - 1], maxV);
            }

            maxV = Math.Max(verticalCuts[0] - 0, maxV);
            maxV = Math.Max(w - verticalCuts[verticalCuts.Length - 1], maxV);

            return (int)(((long)maxH * (long)maxV) % mod);
        }
    }
}
