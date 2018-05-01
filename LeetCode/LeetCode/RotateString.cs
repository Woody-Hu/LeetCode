using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotateString
    {
        public bool RotateStringMethod(string A, string B)
        {
            if (A == null || B == null|| A.Length != B.Length)
            {
                return false;
            }



            string useValue = A + A;

            return useValue.Contains(B);


        }
    }
}
