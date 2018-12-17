using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    }
}
