using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var copy = new int[nums.Length];
            nums.CopyTo(copy, 0);
            Array.Sort(copy);
            var list = new List<int>();
            foreach (var item in nums)
            {
                list.Add(Array.IndexOf(copy, item));
            }

            return list.ToArray();
        }
    }
}
