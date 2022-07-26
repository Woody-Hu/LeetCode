using System;
namespace LeetCode
{
    public class minimum_add_to_make_parentheses_valid
    {
        public int MinAddToMakeValid(string s)
        {
            var res = 0;
            var bal = 0;
            foreach (var item in s)
            {
                if (item == '(')
                {
                    bal++;
                }
                else
                {
                    bal--;
                }

                if (bal == -1)
                {
                    res++;
                    bal++;
                }
            }

            return res + bal;
        }
    }
}
