using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class delete_tree_nodes
    {
        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            if (nodes == 1)
            {
                return value[0] == 0 ? 0 : 1;
            }

            var children = new Dictionary<int, List<int>>();
            for (int i = 0; i < nodes; i++)
            {
                children.Add(i, new List<int>());
            }

            for (int i = 0; i < nodes; i++)
            {
                var parentIndex = parent[i];
                if (parentIndex == -1)
                {
                    continue;
                }

                children[parentIndex].Add(i);
            }

            var res = Visit(value, 0, children);
            return res.Key == 0 ? 0 : res.Value;
        }


        private KeyValuePair<int, int> Visit(int[] value, int index, Dictionary<int, List<int>> children)
        {
            var currentValue = value[index];
            var currentCount = 1;
            foreach (var item in children[index])
            {
                var childRes = Visit(value, item, children);
                if (childRes.Key == 0)
                {
                    continue;
                }

                currentValue += childRes.Key;
                currentCount += childRes.Value;
            }

            return new KeyValuePair<int, int>(currentValue, currentCount);
        }
    }
}
