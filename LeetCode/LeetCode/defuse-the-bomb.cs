using System;
namespace LeetCode
{
	public class defuse_the_bomb
	{
        public int[] Decrypt(int[] code, int k)
        {
            var res = new int[code.Length];
            var e = k >= 0 ? k == 0 ? 0 : 1 : -1;
            for (int i = 0; i < code.Length; i++)
            {
                var sum = 0;
                for (int j = e; j != k + e; j = j + e)
                {
                    sum += code[(i + j + code.Length) % code.Length];
                }

                res[i] = sum;
            }

            return res;
        }
    }
}

