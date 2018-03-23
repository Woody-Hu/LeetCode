using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1bitand2bitCharacters
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if ( 0 != bits[bits.Length - 1])
            {
                return false;
            }
            else
            {
                int useCount = 0;
                for (int i = bits.Length - 2; i >= 0; i--)
                {
                    if (1 == bits[i])
                    {
                        useCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                return useCount % 2 == 0;
            }
        }
    }
}
