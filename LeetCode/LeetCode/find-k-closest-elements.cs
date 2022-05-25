using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class find_k_closest_elements
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var lists = arr.ToList();
            var len = arr.Length - 1;
            if (x <= lists[0])
                return lists.Take(k).ToList(); 
            if (x >= lists[len])
                return lists.TakeLast(k).ToList();

            var lastIndex = lists.BinarySearch(x);
            if (lastIndex < 0)
                lastIndex = -lastIndex - 1;
            var low = Math.Max(0, lastIndex - k - 1);
            var high = Math.Min(len, lastIndex + k - 1);

            while (high - low > k - 1)
            {
                if ((x - lists[low]) <= (lists[high] - x))
                    high--;
                else if ((x - lists[low]) > (lists[high] - x))
                    low++;
                
            }

            return lists.Skip(low).Take(k).ToList();
        }
    }
}
