using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SubtreeofAnotherTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (null == s && null == t)
            {
                return true;
            }
            else if (null == s && null != t)
            {
                return false;
            }
            return InnerMethod(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private bool InnerMethod(TreeNode s, TreeNode t)
        {
            if (null != s && null != t)
            {
                return s.val == t.val && InnerMethod(s.left, t.left) && InnerMethod(s.right, t.right);
            }
            else
            {
                return null == s && null == t;
            }
        }
    }
}
