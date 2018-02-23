using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BinaryNumberwithAlternatingBits
    {
        public bool HasAlternatingBits(int n)
        {
            int? preValue = null;
            int nowValue;

            while (n != 0)
            {
                nowValue = n & 1;

                if (preValue.HasValue && preValue.Value == nowValue)
                {
                    return false;
                }

                preValue = nowValue;

                n = n >> 1;

            }

            return true;
        }
    }
}
