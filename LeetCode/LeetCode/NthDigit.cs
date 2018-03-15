using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NthDigit
    {
        public int FindNthDigit(int n)
        {
            long useLength = 1;

            long useCount = 9;

            long useStart = 1;

            while (n > useLength * useCount)
            {
                n = (int)(n - useLength * useCount);

                useLength++;

                useCount *= 10;
                useStart *= 10;
            }

            useStart += (n - 1) / useLength;

            string useStr = useStart.ToString();

            return int.Parse(useStr.Substring((int)((n - 1) % useLength), 1));
        }
    }
}
