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

            var sortList = new SortedList<string, int>();
            foreach (var item in dic)
            {
                var record = $"{item.Value}_{item.Key}";
                sortList.Add(record, item.Value);
            }

            while (k > 0)
            {
                var first = sortList.First();
                var value = first.Value;
                var subValue = Math.Min(value, k);
                k = k - subValue;
                value = value - subValue;
                if (value == 0)
                {
                    sortList.RemoveAt(0);
                }
            }

            return sortList.Count();
        }
    }
}
