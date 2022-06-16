using System;
using System.Linq;

namespace LeetCode
{
    public class make_two_arrays_equal_by_reversing_sub_arrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            return target.SequenceEqual(arr);
        }
    }
}
