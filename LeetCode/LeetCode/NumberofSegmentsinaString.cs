using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NumberofSegmentsinaString
    {
        public int CountSegments(string s)
        {

            var tempSplitevalue = s.Split(' ');

            var returnValue = from n in tempSplitevalue where !string.IsNullOrWhiteSpace(n) select n;

            return returnValue.Count();
        }
    }
}
