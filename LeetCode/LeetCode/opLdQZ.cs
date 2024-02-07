using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class opLdQZ
	{
        public bool FindTarget(TreeNode root, int k)
        {
            var set = new HashSet<int>();
            return FindTargetInternal(root, k, set);
        }

        private bool FindTargetInternal(TreeNode root, int k, HashSet<int> set)
        {
            if (root == null)
            {
                return false;
            }

            if (set.Contains(k - root.val))
            {
                return true;
            }

            set.Add(root.val);

            return FindTargetInternal(root.left, k, set) || FindTargetInternal(root.right, k, set);
        }
    }
}

