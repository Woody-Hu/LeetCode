using System;
namespace LeetCode
{
    public class Interleaving_String
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1 == null || s2 == null || s3 == null)
                return false;

            var length1 = s1.Length;
            var length2 = s2.Length;
            var length3 = s3.Length;

            if (length1 == 0)
                return s2.CompareTo(s3) == 0;
            if (length2 == 0)
                return s1.CompareTo(s3) == 0;

            if (length1 + length2 != length3)
                return false; 

            var dp = new bool[length1 + 1, length2 + 1];

            dp[0, 0] = true;
            for (int row = 1; row < length1 + 1; row++)
            {
                dp[row, 0] = s1[row - 1] == s3[row - 1] && dp[row - 1, 0];
            }

            for (int col = 1; col < length2 + 1; col++)
            {
                dp[0, col] = s2[col - 1] == s3[col - 1] && dp[0, col - 1];
            }

            for (int row = 1; row < length1 + 1; row++)
            {
                for (int col = 1; col < length2 + 1; col++)
                {
                    var index = row + col - 1; 

                    dp[row, col] = (s1[row - 1] == s3[index] && dp[row - 1, col]) ||
                                   (s2[col - 1] == s3[index] && dp[row, col - 1]);
                }
            }

            return dp[length1, length2];
        }
    }
}
