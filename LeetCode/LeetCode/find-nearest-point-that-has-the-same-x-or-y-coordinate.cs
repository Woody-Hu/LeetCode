using System;
namespace LeetCode
{
    public class find_nearest_point_that_has_the_same_x_or_y_coordinate
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var res = -1;
            var min = int.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                var dx = x - points[i][0];
                var dy = y - points[i][1];
                if (dx * dy == 0)
                {
                    var temp = Math.Abs(dx + dy);
                    if (temp < min)
                    {
                        res = i;
                        min = temp;
                    }
                }
            }

            return res;
        }
    }
}

