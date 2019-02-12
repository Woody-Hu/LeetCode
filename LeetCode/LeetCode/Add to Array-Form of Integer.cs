using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Add_to_Array_Form_of_Integer
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var list = new List<int>();

            for (int i = A.Length - 1; i >=0 || K > 0; i--)
            {
                list.Add((i >= 0 ? A[i] + K : K) % 10);
                K = (i >= 0 ? A[i] + K : K) / 10;
            }

            list.Reverse();

            return list;
        }
    }
}
