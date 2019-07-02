using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Path_In_Zigzag_Labelled_Binary_Tree
    {
        public IList<int> PathInZigZagTree(int label)
        {
            var list = new List<int>();
            var current = label;
            list.Add(current);
            while (current != 1)
            {
                var deep = (int) (Math.Log(current) / Math.Log(2));
                var offset = (int)Math.Pow(2, deep + 1) - 1 - current;
                current = ((int)Math.Pow(2, deep) + offset) / 2;
                list.Add(current);
            }

            list.Reverse();

            return list;
        }
    }
}
