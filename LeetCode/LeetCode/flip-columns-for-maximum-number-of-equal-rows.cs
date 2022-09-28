using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class flip_columns_for_maximum_number_of_equal_rows
    {
        public int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            var res = 0;
            var dic = new Dictionary<string, int>();
            foreach (var row in matrix)
            {
                var stringBuilder1 = new StringBuilder();
                var stringBuilder2 = new StringBuilder();
                foreach (var item in row)
                {
                    stringBuilder1.Append(item);
                    stringBuilder2.Append(item^1);
                }

                var string1 = stringBuilder1.ToString();
                var string2 = stringBuilder2.ToString();
                if (!dic.ContainsKey(string1))
                {
                    dic[string1] = 0;
                }

                dic[string1]++;
                if (!dic.ContainsKey(string2))
                {
                    dic[string2] = 0;
                }

                dic[string2]++;

                res = Math.Max(res, Math.Max(dic[string1], dic[string2]));
            }

            return res;
        }
    }
}
