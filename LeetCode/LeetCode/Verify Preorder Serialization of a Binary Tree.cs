using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Verify_Preorder_Serialization_of_a_Binary_Tree
    {
        public bool IsValidSerialization(string preorder)
        {
            var array = preorder.Split(',');
            var degree = 1;
            foreach (var oneStr in array)
            {
                if (--degree < 0)
                {
                    return false;
                }

                if (oneStr != "#")
                {
                    degree += 2;
                }
            }

            return degree == 0;
        }
    }
}
