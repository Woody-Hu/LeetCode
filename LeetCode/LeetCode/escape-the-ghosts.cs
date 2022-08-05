using System;
namespace LeetCode
{
    public class escape_the_ghosts
    {
        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {
            var start = new int[] { 0, 0 };
            var distance = Distance(start, target);
            foreach (var item in ghosts)
            {
                var tempDistance = Distance(item, target);
                if (tempDistance <= distance)
                {
                    return false;
                }
            }

            return true;
        }

        private int Distance(int[] point1, int[] point2)
        {
            return Math.Abs(point1[0] - point2[0]) + Math.Abs(point1[1] - point2[1]);
        }
    }
}
