using System;
namespace LeetCode
{
    public class valid_parenthesis_string
    {
        public bool CheckValidString(string s)
        {
            var length = s.Length;
            var dp = new bool[length + 1, length + 1];
            dp[0, 0] = true;
            for (int i = 1; i <= length; i++)
            {
                var c = s[i - 1];
                for (int j = 0; j <= i; j++)
                {
                    if (c == '(')
                    {
                        if (j - 1 >= 0)
                        {
                            dp[i, j] = dp[i - 1, j - 1];
                        }
                    }
                    else if (c == ')')
                    {
                        if (j + 1 <= i) dp[i,j] = dp[i - 1,j + 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                        if (j - 1 >= 0) dp[i, j] |= dp[i - 1, j - 1];
                        if (j + 1 <= i) dp[i, j] |= dp[i - 1, j + 1];
                    }
                }
            }

            return dp[length, 0];
        }
    }
}
