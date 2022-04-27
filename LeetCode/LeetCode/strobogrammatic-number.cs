using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class strobogrammatic_number
    {
        public bool IsStrobogrammatic(string num)
        {
            var map = new Dictionary<char, char>()
            {
                { '6', '9'},
                { '9', '6'},
                { '0', '0'},
                { '8', '8'},
                { '1', '1'},
            };

            var l = 0;
            var r = num.Length - 1;
            while (l <= r)
            {
                if (!map.ContainsKey(num[l]) || !map.ContainsKey(num[r]))
                {
                    return false;
                }

                if (map[num[l]] != num[r] || num[l] != map[num[r]])
                {
                    return false;
                }

                l++;
                r--;
            }

            return true;
        }
    }
}
