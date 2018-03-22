using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReachaNumber
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);

            int usestep = 0;

            int usesum = 0;

            while (usesum < target)
            {
                usestep++;
                usesum += usestep;
            }

            while ((usesum - target)%2 != 0)
            {
                usestep++;
                usesum += usestep;
            }

            return usestep;

        }
    }
}
