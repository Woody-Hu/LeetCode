using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCode
{
	public class maximum_average_pass_ratio
	{
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            double getPriority(int[] c) => -((double)(c[0] + 1) / (double)(c[1] + 1) - (double)c[0] / (double)c[1]);
            var q = new PriorityQueue<int[], double>();
            foreach (var c in classes)
            {
                q.Enqueue(c, getPriority(c));
            }
            while (extraStudents-- > 0)
            {
                q.TryDequeue(out var c, out _);
                c[0]++;
                c[1]++;
                q.Enqueue(c, getPriority(c));
            }

            return classes.Select(c => (double)c[0] / (double)c[1]).Sum() / (double)classes.Length;
        }
    }
}

