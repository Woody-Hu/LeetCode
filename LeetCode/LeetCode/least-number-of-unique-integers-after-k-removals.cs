using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class least_number_of_unique_integers_after_k_removals
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }

            var array = dic.Values.ToArray();
            Array.Sort(array);
            var index = 0;
            while (k > 0)
            {
                var first = array[index];
                var value = first;
                var subValue = Math.Min(value, k);
                k = k - subValue;
                value = value - subValue;
                if (value == 0)
                {
                    index++;
                }
            }

            return array.Count() - index;
        }
    }
}
