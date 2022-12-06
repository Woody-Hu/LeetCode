using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class kTOapQ
    {
        public class BSTIterator
        {
            private TreeNode _cur;
            private Stack<TreeNode> _stack;

            public BSTIterator(TreeNode root)
            {
                _cur = root;
                _stack = new Stack<TreeNode>();
            }

            public int Next()
            {
                while (_cur != null)
                {
                    _stack.Push(_cur);
                    _cur = _cur.left;
                }

                _cur = _stack.Pop();
                var res = _cur.val;
                _cur = _cur.right;
                return res;
            }

            public bool HasNext()
            {
                return _cur != null || _stack.Any();
            }
        }
    }
}
