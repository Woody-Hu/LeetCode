using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NumberofAtoms
    {
        public string CountOfAtoms(string formula)
        {
            Stack<Dictionary<String, int>> stack = new Stack<Dictionary<String, int>>();
            Dictionary<String, int> map = new Dictionary<String, int>();
            int i = 0, n = formula.Length;
            while (i < n)
            {
                char c = formula[i]; i++;
                if (c == '(')
                {
                    stack.Push(map);
                    map = new Dictionary<String, int>();
                }
                else if (c == ')')
                {
                    int val = 0;
                    while (i < n && char.IsDigit(formula, i))
                    {
                        val = val * 10 + formula[i] - '0';
                        i = i + 1;
                    }


                    if (val == 0) val = 1;
                    if (stack.Count != 0)
                    {
                        var temp = map;
                        map = stack.Pop();

                        foreach (var item in temp.Keys)
                        {
                            if (!map.ContainsKey(item))
                            {
                                map.Add(item, 0);
                            }

                            map[item] = map[item] + temp[item] * val;

                        }

                    }
                }
                else
                {
                    int start = i - 1;
                    while (i < n && char.IsLower(formula, i))
                    {
                        i++;
                    }
                    String s = formula.Substring(start, i - start);
                    int val = 0;
                    while (i < n && char.IsDigit(formula, i))
                    {
                        val = val * 10 + formula[i] - '0';
                        i = i + 1;
                    }

                    if (val == 0) val = 1;
                    if (!map.ContainsKey(s))
                    {
                        map.Add(s, 0);
                    }

                    map[s] = map[s] + val;
                }
            }
            StringBuilder sb = new StringBuilder();

            var sortMap = map.OrderBy(k => k.Key);

            foreach (var oneKvp in sortMap)
            {
                sb.Append(oneKvp.Key);
                if (oneKvp.Value > 1)
                {
                    sb.Append(oneKvp.Value);
                }
            }

            return sb.ToString();

        }


    }
}
