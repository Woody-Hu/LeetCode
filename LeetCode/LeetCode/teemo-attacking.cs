using System;
namespace LeetCode
{
	public class teemo_attacking
	{
		public int FindPoisonedDuration(int[] timeSeries, int duration)
		{
			var res = 0;
			var expired = 0;
            foreach (var item in timeSeries)
            {
				if (item >= expired)
				{
					res += duration;
				}
				else
				{
					res += item + duration - expired;
				}

				expired = item + duration;
            }

			return res;
		}
	}
}

