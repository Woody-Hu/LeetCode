using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Binary_Tree_Right_Side_View
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var list = new List<TreeNode>();
            var nextLayerList = new List<TreeNode>();
            var returnValue = new List<int>();
            if (null != root)
            {
                list.Add(root);
            }

            while (list.Count != 0)
            {
                returnValue.Add(list[list.Count - 1].val);

                foreach (var oneNode in list)
                {
                    if (null != oneNode.left)
                    {
                        nextLayerList.Add(oneNode.left);
                    }

                    if (null != oneNode.right)
                    {
                        nextLayerList.Add(oneNode.right);
                    }
                }

                list = nextLayerList;
                nextLayerList = new List<TreeNode>(list.Count * 2);
            }

            return returnValue;
        }
    }
}
