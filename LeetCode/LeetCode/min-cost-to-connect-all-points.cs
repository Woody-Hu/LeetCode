using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class min_cost_to_connect_all_points
    {
        public int MinCostConnectPoints(int[][] points)
        {
            if (points.Length <= 1)
            {
                return 0;
            }

            var dictionary = new Dictionary<(int, int), int>();
            for (var i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    dictionary[(i, j)] = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                }
            }

            var pairs = dictionary.OrderBy(it => it.Value).ToList();
            var set = new HashSet<int>() { pairs[0].Key.Item1 };
            var sum = 0;
            while (set.Count < points.Length)
            {
                foreach (var pair in pairs)
                {
                    if ((set.Contains(pair.Key.Item1) && !set.Contains(pair.Key.Item2))
                        || (set.Contains(pair.Key.Item2) && !set.Contains(pair.Key.Item1)))
                    {
                        sum += pair.Value;
                        set.Add(pair.Key.Item1);
                        set.Add(pair.Key.Item2);
                        break;
                    }
                }
            }

            return sum;
        }
    }
}
