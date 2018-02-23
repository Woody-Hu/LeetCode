using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TwoSumIV_InputisaBST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> useSet = new HashSet<int>();
            return DFS(root, k, useSet);
        }

        private bool DFS(TreeNode root,int k, HashSet<int> useSet)
        {
            if (null == root)
            {
                return false;
            }


            if (useSet.Contains(k-root.val))
            {
                return true;
            }

            useSet.Add(root.val);

            return DFS(root.left, k, useSet) || DFS(root.right, k, useSet);
        }
    }
}
