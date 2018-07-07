using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class BuddyStrings
    {
        public bool BuddyStringsMethod(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            if (A.Equals(B))
            {
                return A.ToHashSet().Count() < A.Length;
            }

            List<int> lstDif = new List<int>();

           for(int i =0; i<A.Length;i++)
            {
                if (A[i] != B[i])
                {
                    lstDif.Add(i);
                }
            }

            return lstDif.Count == 2 && A[lstDif[0]] == B[lstDif[1]] && B[lstDif[0]] == A[lstDif[1]];

   

        }
    }
}