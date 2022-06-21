using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_elements_in_a_contaminated_binary_tree
    {
        public class FindElements
        {
            private HashSet<int> _set = new HashSet<int>();

            public FindElements(TreeNode root)
            {
                root.val = 0;
                _set.Add(0);
                Fix(root);
            }

            private void Fix(TreeNode root)
            {
                if (root.left != null)
                {
                    var leftValue = root.left.val;
                    leftValue = (root.val << 1) + 1;
                    _set.Add(leftValue);
                    root.left.val = leftValue;
                    Fix(root.left);
                }

                if (root.right != null)
                {
                    var rightValue = root.right.val;
                    rightValue = (root.val << 1) + 2;
                    _set.Add(rightValue);
                    root.right.val = rightValue;
                    Fix(root.right);
                }
            }

            public bool Find(int target)
            {
                return _set.Contains(target);
            }
        }
    }
}
