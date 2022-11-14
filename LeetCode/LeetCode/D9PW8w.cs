using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class D9PW8w
    {
        public int TransportationHub(int[][] path)
        {
            var set = new HashSet<int>();
            var input = new Dictionary<int, int>();
            var output = new Dictionary<int, int>();
            foreach (var item in path)
            {
                set.Add(item[0]);
                set.Add(item[1]);
                if (!input.ContainsKey(item[1]))
                {
                    input.Add(item[1], 0);
                }

                input[item[1]]++;

                if (!output.ContainsKey(item[0]))
                {
                    output.Add(item[0], 0);
                }

                output[item[0]]++;
            }

            foreach (var item in set)
            {
                if (input.ContainsKey(item) && input[item] == set.Count - 1 && !output.ContainsKey(item))
                {
                    return item;
                }
            }

            return -1;
        }
    }
}
