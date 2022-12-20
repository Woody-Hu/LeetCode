using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class print_words_vertically
    {
        public IList<string> PrintVertically(string s)
        {
            var res = new List<string>();
            var array = s.Split(' ');
            var len = array.Select(k => k.Count()).Max();
            for (int i = 0; i < len; i++)
            {
                var sb = new StringBuilder();
                foreach (var item in array)
                {
                    if (i < item.Length)
                    {
                        sb.Append(item[i]);
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }

                res.Add(sb.ToString().TrimEnd());
            }

            return res;
        }
    }
}
