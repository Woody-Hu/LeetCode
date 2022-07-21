using System;
using System.Linq;

namespace LeetCode
{
    public class number_of_rectangles_that_can_form_the_largest_square
    {
        public int CountGoodRectangles(int[][] rectangles)
        {
            var res = 0;
            var max = 0;
            foreach (var item in rectangles)
            {
                var currentMin = item.Min();
                if (currentMin > max)
                {
                    max = currentMin;
                    res = 1;
                }
                else if (currentMin == max)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
