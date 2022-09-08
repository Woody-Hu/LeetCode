using System;
namespace LeetCode
{
    public class beautiful_arrangement_ii
    {
        public int[] ConstructArray(int n, int k)
        {
            var res = new int[n];
            var index = 0;
            for (int i = 1; i < n - k; i++)
            {
                res[index++] = i;
            }

            for (int i = n -k , j = n; i <=j; i++, j--)
            {
                res[index++] = i;
                if (i != j)
                {
                    res[index++] = j;
                }
            }

            return res;
        }
    }
}
