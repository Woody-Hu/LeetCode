using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseBits
    {
        public uint reverseBits(uint n)
        {
            uint returnValue = 0;

            for (int i = 0; i < 32; i++)
            {
                if (1 == (n & 1))
                {
                    returnValue = (returnValue << 1) + 1;
                }
                else
                {
                    returnValue = returnValue << 1;
                }
                n = n >> 1;
            }
            return returnValue;
        }
    }
}
