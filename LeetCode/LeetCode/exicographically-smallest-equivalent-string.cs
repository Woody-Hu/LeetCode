using System;
using System.Text;

namespace LeetCode
{
    public class exicographically_smallest_equivalent_string
    {
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            var union = new Union();
            for (int i = 0; i < s1.Length; i++)
            {
                union.Link(s1[i] - 'a', s2[i] - 'a');
            }

            var stringBuilder = new StringBuilder();
            foreach (var item in baseStr)
            {
                var p = union.Find(item - 'a');
                stringBuilder.Append((char)(p + 'a'));
            }

            return stringBuilder.ToString();
        }

        private class Union
        {
            private int[] _nums = new int[26];

            public Union()
            {
                Array.Fill(_nums, -1);
            }

            public void Link(int v1, int v2)
            {
                var p1 = Find(v1);
                var p2 = Find(v2);
                if (p1 == p2)
                {
                    return;
                }

                if (p1 < p2)
                {
                    _nums[p2] = p1;
                }
                else
                {
                    _nums[p1] = p2;
                }

            }

            public int Find(int i)
            {
                if (_nums[i] < 0)
                {
                    return i;
                }

                _nums[i] = Find(_nums[i]);
                return _nums[i];
            }
        }
    }
}
