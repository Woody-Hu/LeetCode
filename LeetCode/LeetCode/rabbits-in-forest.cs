using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class rabbits_in_forest
    {
        public int NumRabbits(int[] answers)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in answers)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }

            var res = 0;
            foreach (var item in dic)
            {
                var x = item.Key;
                var y = item.Value;
                res += ((x + y) / (x + 1)) * (x + 1);
            }

            return res;
        }
    }
}
