using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PoorPigs
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            return (int)Math.Ceiling(Math.Log(buckets) / Math.Log(minutesToTest / minutesToDie + 1));
        }
    }
}
