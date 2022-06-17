using System;
namespace LeetCode
{
	public class count_of_matches_in_tournament
	{
		public int NumberOfMatches(int n)
		{
			var res = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    res += n / 2;
                    n /= 2;
                }
                else
                {
                    res += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }

            return res;
		}
	}
}

