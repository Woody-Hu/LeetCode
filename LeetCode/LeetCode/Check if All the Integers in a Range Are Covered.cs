using System;
namespace LeetCode
{
    public class Check_if_All_the_Integers_in_a_Range_Are_Covered
    {
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            Array.Sort(ranges, (x, y) => x[0] - y[0] );
            foreach (var item in ranges)
            {
                if (left >= item[0] && left <= item[1])
                {
                    left = item[1] + 1;
                }
            }

            return left > right;
        }
    }
}
