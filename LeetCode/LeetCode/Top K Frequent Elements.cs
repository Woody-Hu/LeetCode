using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Top_K_Frequent_Elements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int,int>();
            foreach (var value in nums)
            {
                if (!dic.ContainsKey(value))
                {
                    dic.Add(value,0);
                }

                dic[value] += 1;
            }

            var array = new List<int>[nums.Length + 1];
            foreach (var oneKvp in dic)
            {
                var value = oneKvp.Value;
                if (array[value] == null)
                {
                    array[value] = new List<int>();
                }

                array[value].Add(oneKvp.Key);
            }

            var list = new List<int>();
            for (int i = array.Length - 1; i > 0 && k > 0; i--)
            {
                if (array[i] != null)
                {
                    list.AddRange(array[i]);
                    k -= array[i].Count;
                }
            }

            return list;
        }
    }
}
