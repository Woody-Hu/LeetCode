using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Powerful_Integers
    {
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            var set = new HashSet<int>();

            for (var i = 1; i <= bound; i = i * (x>1?x:bound+1))
            {
                for (var j = 1; j + i <= bound; j = j * (y > 1 ? y : bound + 1))
                {
                    set.Add(i + j);
                }
            }

            return set.ToList();
        }
    }
}
