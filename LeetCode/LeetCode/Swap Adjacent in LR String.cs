using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode
{
    class Swap_Adjacent_in_LR_String
    {
        public bool CanTransform(string start, string end)
        {
            var length = start.Length;
            var p1 = -1;
            var p2 = -1;
            while (p1++ < length && p2++ < length)
            {
                while (p1 < length && start[p1] == 'X')
                {
                    p1++;
                }

                while (p2 < length && end[p2] == 'X')
                {
                    p2++;
                }

                if ((p1<length)^(p2<length))
                {
                    return false;
                }

                if (p1 < length && p2 < length &&
                    ((start[p1] != end[p2]) ||
                     (start[p1] == 'L' && p1 < p2) ||
                     (start[p1] == 'R' && p1 > p2)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
