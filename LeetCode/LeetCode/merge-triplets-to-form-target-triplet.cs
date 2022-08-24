using System;
namespace LeetCode
{
    public class merge_triplets_to_form_target_triplet
    {
        public bool MergeTriplets(int[][] triplets, int[] target)
        {
            var x = target[0];
            var y = target[1];
            var z = target[2];
            var (a, b, c) = (0, 0, 0);
            foreach (var item in triplets)
            {
                var x1 = item[0];
                var y1 = item[1];
                var z1 = item[2];
                if (x1 <= x && y1<= y && z1 <= z )
                {
                    (a, b, c) = (Math.Max(x1, a), Math.Max(y1, b), Math.Max(z1, c));
                }
            }

            return (a, b, c) == (x, y, z);
        }
    }
}
