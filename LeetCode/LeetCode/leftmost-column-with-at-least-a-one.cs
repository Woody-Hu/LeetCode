using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class leftmost_column_with_at_least_a_one
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var dimensions = binaryMatrix.Dimensions();
            var rows = dimensions[0];
            var columens = dimensions[1];
            var res = columens;
            for (int i = 0; i < rows; i++)
            {
                var left = -1;
                var right = columens;
                while (left + 1 < right)
                {
                    var mid = (left + right) / 2;
                    if (binaryMatrix.Get(i, mid) == 1)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid;
                    }
                }

                res = Math.Min(res, right);
            }

            if (res == columens)
            {
                return -1;
            }

            return res;
        }


        public abstract class BinaryMatrix
        {
           public abstract int Get(int row, int col);
            public abstract IList<int> Dimensions();
        }
    }
}
