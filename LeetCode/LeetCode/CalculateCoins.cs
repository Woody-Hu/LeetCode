using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CalculateCoins
    {
        public int Calculate(int n)
        {
            HashSet<int> useSet = new HashSet<int>();

            var useLength = n / 2;

            for (int i = 0; i < useLength; i++)
            {
                var result = i ^ (n - i);
                useSet.Add(result);
            }

            return useSet.Count;
        }
    }
}
