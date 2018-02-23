using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;

            int val = (t1 == null ? 0 : t1.val) + (t2 == null ? 0 : t2.val);
            TreeNode newNode = new TreeNode(val);

            newNode.left = MergeTrees(t1 == null ? null : t1.left, t2 == null ? null : t2.left);
            newNode.right = MergeTrees(t1 == null ? null : t1.right, t2 == null ? null : t2.right);

            return newNode;
        }

      
    }
}
