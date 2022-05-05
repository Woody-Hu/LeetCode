using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class delete_tree_nodes
    {
        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            var relations = new int[nodes];
            for (int i = 0; i < nodes; i++)
            {
                relations[i] = i;
            }

            for (int i = 0; i < nodes; i++)
            {
                if (parent[i] == -1)
                {
                    continue;
                }

                Merge(relations, parent[i], i);
            }

            var dic = new Dictionary<int, KeyValuePair<int, int>>();
            for (int i = 0; i < nodes; i++)
            {
                var ascendent = Find(relations, i);
                if (!dic.ContainsKey(ascendent))
                {
                    var pair = new KeyValuePair<int, int>(1, value[i]);
                    dic.Add(ascendent, pair);
                }
                else
                {
                    var exist = dic[ascendent];
                    var pair = new KeyValuePair<int, int>(exist.Key + 1, exist.Value + value[i]);
                    dic[ascendent] = pair;
                }
            }

            var res = 0;
            foreach (var item in dic)
            {
                if (item.Value.Value != 0)
                {
                    res += item.Value.Key;
                }
            }

            return res;
        }


        private int Find(int[] relations, int i)
        {
            if (relations[i] == i)
            {
                return i;
            }
            else
            {
                relations[i] = Find(relations, relations[i]);
                return relations[i];
            }
        }

        private void Merge(int[] relations, int parent, int child)
        {
            relations[Find(relations, child)] = relations[Find(relations, parent)];
        }
    }
}
