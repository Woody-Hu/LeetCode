using System;
using System.Text;

namespace LeetCode
{
    public class longest_happy_string
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            var res = new StringBuilder();
            Pair[] arr = { new Pair(a, 'a'), new Pair(b, 'b'), new Pair(c, 'c') };

            while (true)
            {
                Array.Sort(arr, (p1, p2) => p2.Count - p1.Count);
                bool hasNext = false;
                foreach (Pair pair in arr)
                {
                    if (pair.Count <= 0)
                    {
                        break;
                    }

                    int m = res.Length;
                    if (m >= 2 && res[m - 2] == pair.CharValue && res[m - 1] == pair.CharValue)
                    {
                        continue;
                    }

                    hasNext = true;
                    res.Append(pair.CharValue);
                    pair.Count--;
                    break;
                }

                if (!hasNext)
                {
                    break;
                }
            }

            return res.ToString();
        }

        private class Pair
        {
            public int Count { get; set; }
            public char CharValue { get; set; }

            public Pair(int count, char charValue)
            {
                this.Count = count;
                this.CharValue = charValue;
            }
        }
    }
}
