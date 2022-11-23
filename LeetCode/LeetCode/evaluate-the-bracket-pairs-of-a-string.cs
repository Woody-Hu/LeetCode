using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class evaluate_the_bracket_pairs_of_a_string
    {
        public string Evaluate(string s, IList<IList<string>> knowledge)
        {
            var dic = new Dictionary<string, string>();
            foreach (var item in knowledge)
            {
                dic.Add(item[0], item[1]);
            }

            var res = new StringBuilder();
            var inBrack = false;
            var temp = new StringBuilder();
            foreach (var item in s)
            {
                if (item == '(')
                {
                    inBrack = true;
                    temp.Clear();
                }
                else if (item == ')')
                {
                    var key = temp.ToString();
                    inBrack = false;
                    if (dic.TryGetValue(key, out var value))
                    {
                        res.Append(value);
                    }
                    else
                    {
                        res.Append('?');
                    }
                }
                else if (inBrack)
                {
                    temp.Append(item);
                }
                else
                {
                    res.Append(item);
                }
            }

            return res.ToString();
        }
    }
}
