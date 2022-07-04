using System;
using System.Linq;

namespace LeetCode
{
    public class count_asterisks
    {
        public int CountAsterisks(string s)
        {
            var splited = s.Split('|');
            var res = 0;
            for (int i = 0; i < splited.Length; i = i +2)
            {
                res += splited[i].Count(k => k == '*');
            }

            return res;
        }
    }
}
