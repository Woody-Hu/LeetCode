using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_K_Pairs_with_Smallest_Sums
    {
        public IList<int[]> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var list = new List<Pair>();
            if (nums1.Length == 0 || nums2.Length == 0 || k == 0)
                return new List<int[]>();

            for (int i = 0; i < nums1.Length && i < k; i++)
                list.Add(new Pair(){Num1 = nums1[i], Num2 = nums2[0], Index2 = 0});
            list.Sort();

            var res = new List<int[]>();
            while (k-- > 0 && list.Count != 0)
            {
                var cur = list[0];
                list.RemoveAt(0);
                res.Add(new int[] { cur.Num1, cur.Num2 });
                if (cur.Index2 == nums2.Length - 1)
                    continue;
                list.Add(new Pair { Num1 = cur.Num1, Num2 = nums2[cur.Index2 + 1], Index2 = cur.Index2 + 1 });
                list.Sort();
            }

            return res;
        }

        private class Pair : IComparable<Pair>
        {
            internal int Num1 { get; set; }

            internal int Num2 { get; set; }

            internal int Index2 { get; set; }

            public int CompareTo(Pair other)
            {
                return (Num1 + Num2).CompareTo(other.Num1 + other.Num2);
            }
        }
    }
}
