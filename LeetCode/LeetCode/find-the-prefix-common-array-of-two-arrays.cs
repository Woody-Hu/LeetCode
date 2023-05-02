using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_the_prefix_common_array_of_two_arrays
	{
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            var setA = new HashSet<int>();
            var setB = new HashSet<int>();
            var c = 0;
            var res = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                setA.Add(A[i]);
                setB.Add(B[i]);
                if (setA.Contains(B[i]))
                {
                    c++;
                }

                if (setB.Contains(A[i]))
                {
                    c++;
                }

                if (A[i] == B[i])
                {
                    c--;
                }

                res[i] = c;
            }

            return res;
        }
    }
}

