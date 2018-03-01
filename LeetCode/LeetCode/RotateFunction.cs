using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotateFunction
    {
        public int MaxRotateFunction(int[] A)
        {
            int countN = A.Length;

            int f = 0;

            int sum = 0;

            for (int i = 0; i < countN; i++)
            {
                f += i * A[i];
                sum += A[i];
            }

            int max =f;
             
            for (int i = countN - 1; i >= 0; i--)
            {
                f = f + sum - countN * A[i];

                max = Math.Max(max, f);
            }

            return max;

        }
    }
}
