using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class create_binary_tree_from_descriptions
    {
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var dict = new Dictionary<int, TreeNode>();
            var set = new HashSet<int>();
            foreach (var item in descriptions)
            {
                var p = item[0];
                var cv = item[1];
                var isL = item[2];
                if (!dict.ContainsKey(p))
                {
                    dict.Add(p, new TreeNode(p));
                }

                if (!dict.ContainsKey(cv))
                {
                    dict.Add(cv, new TreeNode(cv));
                }

                if (isL == 1)
                {
                    dict[p].left = dict[cv];
                }
                else
                {
                    dict[p].right = dict[cv];
                }

                set.Add(cv);
            }

            var keys = dict.Keys;
            foreach (var item in keys)
            {
                if (!set.Contains(item))
                {
                    return dict[item];
                }
            }

            return null;
        }
    }
}
