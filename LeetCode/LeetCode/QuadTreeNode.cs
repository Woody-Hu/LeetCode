using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class QuadTreeNode
    {
        public bool val;
        public bool isLeaf;
        public QuadTreeNode topLeft;
        public QuadTreeNode topRight;
        public QuadTreeNode bottomLeft;
        public QuadTreeNode bottomRight;

        public QuadTreeNode() { }
        public QuadTreeNode(bool _val, bool _isLeaf, QuadTreeNode _topLeft, QuadTreeNode _topRight, QuadTreeNode _bottomLeft, QuadTreeNode _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
}
