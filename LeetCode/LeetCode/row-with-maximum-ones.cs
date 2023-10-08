using System;
namespace LeetCode
{
	public class row_with_maximum_ones
	{
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            var count = 0;
            var rowI = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                var temp = 0;
                foreach (var item in mat[i])
                {
                    temp += item;
                }

                if (temp > count)
                {
                    rowI = i;
                    count = temp;
                }
            }

            return new int[] { rowI, count };
        }
    }
}

