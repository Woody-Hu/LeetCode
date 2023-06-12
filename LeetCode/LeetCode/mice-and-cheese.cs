using System;
namespace LeetCode
{
	public class mice_and_cheese
	{
        public int MiceAndCheese(int[] reward1, int[] reward2, int k)
        {
            var res = 0;
            var n = reward1.Length;
            var diff = new int[n];
            for (int i = 0; i < n; i++)
            {
                res += reward2[i];
                diff[i] = reward1[i] - reward2[i];
            }

            Array.Sort(diff);
            for (int i = 1; i <= k ; i++)
            {
                res += diff[n - i];
            }

            return res;
        }
    }
}

