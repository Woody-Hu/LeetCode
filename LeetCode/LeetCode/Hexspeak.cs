using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Hexspeak
    {
        public string ToHexspeak(string num)
        {
            var longValue = long.Parse(num);
            var dict = new Dictionary<int, char>();
            dict.Add(0, 'O');
            dict.Add(1, 'I');
            dict.Add(10, 'A');
            dict.Add(11, 'B');
            dict.Add(12, 'C');
            dict.Add(13, 'D');
            dict.Add(14, 'E');
            dict.Add(15, 'F');

            var sb = new StringBuilder();
            while (longValue > 0)
            {
                int rem = (int)(longValue % 16);
                if (!dict.ContainsKey(rem)) return "ERROR";
                longValue = longValue / 16;
                sb.Insert(0, dict[rem]);
            }

            return sb.ToString();
        }
    }
}
