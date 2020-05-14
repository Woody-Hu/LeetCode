using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Generate_a_String_With_Characters_That_Have_Odd_Counts
    {
        public string GenerateTheString(int n)
        {
            var res = new StringBuilder();
            if (n % 2 == 0)
            {
                for (int i = 0; i < n - 1 ; i++)
                {
                    res.Append('a');
                }

                res.Append('b');
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    res.Append('a');
                }
            }

            return res.ToString();
        }
    }
}
