using System;
namespace LeetCode
{
    public class Find_the_Highest_Altitude
    {
        public int LargestAltitude(int[] gain)
        {
            var res = 0;
            var current = res;
            foreach (var item in gain)
            {
                var next = current + item;
                res = Math.Max(res, next);
                current = next;
            }

            return res;
        }
    }
}
