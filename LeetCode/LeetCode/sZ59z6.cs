using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class sZ59z6
    {
        public int NumColor(TreeNode root)
        {
            var set = new HashSet<int>();
            Visit(root, ref set);
            return set.Count;
        }

        private void Visit(TreeNode root, ref HashSet<int> set)
        {
            if (root == null)
            {
                return;
            }

            set.Add(root.val);
            Visit(root.left, ref set);
            Visit(root.right, ref set);
        }
    }
}

