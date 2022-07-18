using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class cells_in_a_range_on_an_excel_sheet
    {
        public IList<string> CellsInRange(string s)
        {
            var c1 = s[0] - 'A';
            var r1 = s[1] - '0';
            var c2 = s[3] - 'A';
            var r2 = s[4] - '0';
            var res = new List<string>();
            for (int i = c1; i <= c2; i++)
            {
                for (int j = r1; j <= r2; j++)
                {
                    res.Add($"{(char)(i + 'A')}{(char)(j + '0')}");
                }
            }

            return res;
        }
    }
}
