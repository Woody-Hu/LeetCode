using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class The_K_Weakest_Rows_in_a_Matrix
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var len = mat.Length;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        arr[i] = j;
                        break;
                    }
                    if (j == mat[0].Length - 1 && mat[i][j] == 1)
                        arr[i] = j + 1;
                }
            }

            int[] res = new int[k];
            int[] arr1 = new int[len];
            arr.CopyTo(arr1, 0);
            Array.Sort(arr1);
            var set = new HashSet<int>();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr1[i] == arr[j] && !set.Contains(j))
                    {
                        res[i] = j;
                        set.Add(j);
                        break;
                    }

                }
            }

            return res;
        }
    }
}
