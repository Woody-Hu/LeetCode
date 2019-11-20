using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Unique_Number_of_Occurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item] = dict[item] + 1;
            }

            var set = new HashSet<int>();

            foreach (var keyValuePair in dict)
            {
                if (set.Contains(keyValuePair.Value))
                {
                    return false;
                }

                set.Add(keyValuePair.Value);
            }

            return true;
        }
    }
}
