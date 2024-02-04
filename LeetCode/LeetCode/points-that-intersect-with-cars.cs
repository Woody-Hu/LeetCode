using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class points_that_intersect_with_cars
	{
        public int NumberOfPoints(IList<IList<int>> nums)
        {
            int minPoint = int.MaxValue, maxPoint = int.MinValue;
            foreach (IList<int> car in nums)
            {
                minPoint = Math.Min(minPoint, car[0]);
                maxPoint = Math.Max(maxPoint, car[1]);
            }
            int[] diffs = new int[maxPoint - minPoint + 1];
            foreach (IList<int> car in nums)
            {
                int start = car[0], end = car[1];
                diffs[start - minPoint]++;
                if (end < maxPoint)
                {
                    diffs[end - minPoint + 1]--;
                }
            }
            int covered = 0;
            int count = 0;
            for (int i = minPoint; i <= maxPoint; i++)
            {
                count += diffs[i - minPoint];
                if (count > 0)
                {
                    covered++;
                }
            }
            return covered;
        }
    }
}

