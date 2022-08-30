using System;
namespace LeetCode
{
    public class score_of_parentheses
    {
        public int ScoreOfParentheses(string s)
        {
            var blance = 0;
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var item = s[i];
                if (item == '(')
                {
                    blance++;
                }
                else
                {
                    blance--;
                    if (s[i - 1] == '(' )
                    {
                        res += 1 << blance;
                    }
                }
            }

            return res;
        }
    }
}
