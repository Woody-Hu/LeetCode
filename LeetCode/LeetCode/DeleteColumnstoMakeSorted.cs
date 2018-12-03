using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DeleteColumnstoMakeSorted
    {
        public int MinDeletionSize(string[] A)
        {
            if (0 == A.Length || 0 == A[0].Length)
            {
                return 0;
            }

            var arrayLength = A.Length;
            var stringLength = A[0].Length;
            var count = 0;
            for (var i = 0; i < stringLength; i++)
            {
                for (var j = 0; j < arrayLength - 1; j++)
                {
                    if (A[j][i] > A[j+1][i])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
