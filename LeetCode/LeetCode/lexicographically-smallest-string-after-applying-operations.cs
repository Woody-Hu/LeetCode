using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class lexicographically_smallest_string_after_applying_operations
	{
        public string FindLexSmallestString(string s, int a, int b)
        {
            var n = s.Length;
            var set = new HashSet<string>();
            var res = s;
            var queue = new Queue<string>();
            queue.Enqueue(s);
            set.Add(s);
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current.CompareTo(res) < 0)
                {
                    res = current;
                }

                var added = Add(current, a);
                var offset = current.Substring(n - b) + current.Substring(0, n - b);
                if (!set.Contains(added))
                {
                    queue.Enqueue(added);
                    set.Add(added);
                }

                if (!set.Contains(offset))
                {
                    queue.Enqueue(offset);
                    set.Add(offset);
                }
            }

            return res;
        }

        public String Add(String s, int a)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (i % 2 != 0)
                {
                    sb.Append(((c - '0') + a) % 10);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}

