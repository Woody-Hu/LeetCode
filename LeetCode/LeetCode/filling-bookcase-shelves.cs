using System;
namespace LeetCode
{
	public class filling_bookcase_shelves
	{
        public int MinHeightShelves(int[][] books, int shelfWidth)
        {
            var n = books.Length;
            var dp = new int[n + 1];
            for (int i = n - 1; i >= 0; i--)
            {
                var ch = 0;
                var leftWidth = shelfWidth;
                var mh = int.MaxValue;
                for (int j = i; j < n && leftWidth >= books[j][0]; j++)
                {
                    leftWidth -= books[j][0];
                    ch = Math.Max(ch, books[j][1]);
                    mh = Math.Min(mh, ch + dp[j + 1]);
                }

                dp[i] = mh;
            }

            return dp[0];
        }
    }
}

