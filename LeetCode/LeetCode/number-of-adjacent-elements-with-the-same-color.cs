using System;
namespace LeetCode
{
	public class number_of_adjacent_elements_with_the_same_color
	{
        public int[] ColorTheArray(int n, int[][] queries)
        {
            var res = new int[queries.Length];
            var array = new int[n + 2];
            var currentCount = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                var ai = queries[i][0] +1;
                var cv = queries[i][1];
                if (array[ai] > 0)
                {
                    currentCount -= (array[ai] == array[ai - 1] ? 1 : 0) + (array[ai] == array[ai + 1] ? 1 : 0);
                }

                array[ai] = cv;
                currentCount += (array[ai] == array[ai - 1] ? 1 : 0) + (array[ai] == array[ai + 1] ? 1 : 0);
                res[i] = currentCount;
            }

            return res;
        }
    }
}

