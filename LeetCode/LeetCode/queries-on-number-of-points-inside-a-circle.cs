using System;
namespace LeetCode
{
    public class queries_on_number_of_points_inside_a_circle
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            var array = new int[queries.Length];
            var i = 0;
            foreach (var query in queries)
            {
                int count = 0;
                foreach (var point in points)
                {
                    var distance = Math.Sqrt(Math.Abs(query[0] - point[0]) * Math.Abs(query[0] - point[0]) + Math.Abs(query[1] - point[1]) * Math.Abs(query[1] - point[1]));
                    if (distance <= query[2])
                    {
                        count++;
                    }
                }
                array[i++] = count;
            }
            return array;
        }
    }
}
