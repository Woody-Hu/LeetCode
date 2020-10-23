using System;
namespace LeetCode
{
    public class Maximum_Nesting_Depth_of_the_Parentheses
    {
        public Maximum_Nesting_Depth_of_the_Parentheses()
        {
        }

        public int MaxDepth(string s)
        {
            var res = int.MinValue;
            var count = 0;
            foreach (var item in s)
            {
                if (item == '(')
                {
                    count++;
                }
                else if (item == ')')
                {
                    count--;
                }

                res = Math.Max(count, res);

            }

            return res;
        }
    }
}
