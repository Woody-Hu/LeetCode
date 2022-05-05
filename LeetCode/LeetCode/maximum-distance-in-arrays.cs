using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_distance_in_arrays
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            var res = 0;
            var max = arrays[0][arrays[0].Count - 1];
            var min = arrays[0][0];
            for (int i = 1; i < arrays.Count; i++)
            {
                res = Math.Max(res, Math.Max(Math.Abs(max - arrays[i][0]), Math.Abs(arrays[i][arrays[i].Count - 1] - min)));
                max = Math.Max(max, arrays[i][arrays[i].Count - 1]);
                min = Math.Min(min, arrays[i][0]);
            }

            return res;
        }
    }
}
