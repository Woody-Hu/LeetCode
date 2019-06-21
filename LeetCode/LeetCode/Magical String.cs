using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Magical_String
    {
        public int MagicalString(int n)
        {
            int res = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(1);
            for (int i = 0, j = 0; j < n; i++)
            {
                if (sb[j] == '1')
                {
                    res++;
                    if (sb[i] == '1')
                    {
                        sb.Append('2');
                        j++;
                    }
                    else
                    {
                        sb.Append('1');
                        if (j + 1 < n) res++;
                        sb.Append('2');
                        j += 2;
                    }
                }
                else
                {
                    if (sb[i] == '1')
                    {
                        sb.Append('1');
                        j++;
                    }
                    else
                    {
                        sb.Append('2');
                        sb.Append('1');
                        j += 2;
                    }
                }
            }

            return res;
        }
    }
}
