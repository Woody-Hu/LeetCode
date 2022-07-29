using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class equal_row_and_column_pairs
    {
        public int EqualPairs(int[][] grid)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < grid.Length; i++)
            {
                var stringBuilder = new StringBuilder();
                for (int j = 0; j < grid[i].Length; j++)
                {
                    stringBuilder.Append(grid[i][j]);
                    stringBuilder.Append(",");
                }

                var stringValue = stringBuilder.ToString();
                if (!dic.ContainsKey(stringValue))
                {
                    dic[stringValue] = 1;
                }
                else
                {
                    dic[stringValue] = dic[stringValue] + 1;
                }
            }

            var res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                var stringBuilder = new StringBuilder();
                for (int j = 0; j < grid[i].Length; j++)
                {
                    stringBuilder.Append(grid[j][i]);
                    stringBuilder.Append(",");
                }

                var stringValue = stringBuilder.ToString();
                if (dic.ContainsKey(stringValue))
                {
                    res += dic[stringValue];
                }
            }

            return res;
        }
    }
}
