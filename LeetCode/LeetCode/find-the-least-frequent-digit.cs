using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class find_the_least_frequent_digit
    {
        public int GetLeastFrequentDigit(int n)
        {
            IDictionary<int, int> counts = new Dictionary<int, int>();
            while (n > 0)
            {
                int digit = n % 10;
                counts.TryAdd(digit, 0);
                counts[digit]++;
                n /= 10;
            }
            int leastFrequentDigit = -1, minCount = int.MaxValue;
            foreach (KeyValuePair<int, int> pair in counts)
            {
                int digit = pair.Key, count = pair.Value;
                if (count < minCount || (count == minCount && digit < leastFrequentDigit))
                {
                    leastFrequentDigit = digit;
                    minCount = count;
                }
            }
            return leastFrequentDigit;

        }
    }
}
