using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class valid_square
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            var set = new HashSet<int>();
            set.Add(CalculateDistance(p1, p2));
            set.Add(CalculateDistance(p1, p3));
            set.Add(CalculateDistance(p1, p4));
            set.Add(CalculateDistance(p2, p3));
            set.Add(CalculateDistance(p2, p4));
            set.Add(CalculateDistance(p3, p4));
            if (set.Any(k => k ==0))
            {
                return false;
            }

            return set.Count == 2;
        }

        private int CalculateDistance(int[] p1, int[] p2)
        {
            return (p1[0] - p2[0]) * (p1[0] - p2[0]) + (p1[1] - p2[1]) * (p1[1] - p2[1]);
        }
    }
}
