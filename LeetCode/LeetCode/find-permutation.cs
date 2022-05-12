using System;
namespace LeetCode
{
    public class find_permutation
    {
        public int[] FindPermutation(string s)
        {
            var res = new int[s.Length + 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = i + 1;
            }

            int i1 = 1;
            while (i1 <= s.Length)
            {
                var i2 = i1;
                while (i1 <= s.Length && s[i1- 1] == 'D')
                {
                    i1++;
                }

                for (int j = 0; j < (i1 - i2 + 1)/2; j++)
                {
                    var temp = res[j + i2 - 1];
                    res[j + i2 - 1] = res[i1 - j - 1];
                    res[i1 - j - 1] = temp;
                }

                i1++;
            }

            return res;
        }
    }
}
