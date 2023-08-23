using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class check_completeness_of_a_binary_tree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            var list = new List<ANode>
            {
                new ANode() { Node = root, Code = 1 }
            };

            var i = 0;
            while (i < list.Count)
            {
                var cur = list[i++];
                if (cur.Node != null)
                {
                    list.Add(new ANode() { Node = cur.Node.left, Code = cur.Code * 2 });
                    list.Add(new ANode() { Node = cur.Node.right, Code = cur.Code * 2 + 1 });
                }
            }

            return list[list.Count - 1].Code == list.Count;
        }

        class ANode
        {

            public TreeNode Node { get; set; }
            public int Code { get; set; }
        }
    }
}

