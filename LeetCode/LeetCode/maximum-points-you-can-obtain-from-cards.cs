using System;
using System.Linq;

namespace LeetCode
{
	public class maximum_points_you_can_obtain_from_cards
	{
        public int MaxScore(int[] cardPoints, int k)
        {
            var n = cardPoints.Length;
            var ws = n - k;
            var sum = 0;
            for (int i = 0; i < ws; i++)
            {
                sum += cardPoints[i];
            }

            var minSum = sum;
            for (int i = ws; i < n; i++)
            {
                sum += cardPoints[i] - cardPoints[i - ws];
                minSum = Math.Min(minSum, sum);
            }

            return cardPoints.Sum() - minSum;
        }
    }
}

