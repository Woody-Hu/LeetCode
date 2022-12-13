using System;
namespace LeetCode
{
    public class sum_of_beauty_of_all_substrings
    {
        public int BeautySum(string s)
        {
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var array = new int[26];
                var max = 0;
                for (int j = i; j < s.Length; j++)
                {
                    array[s[j] - 'a']++;
                    max = Math.Max(max, array[s[j] - 'a']);
                    var min = s.Length;
                    for (int z = 0; z < 26; z++)
                    {
                        if (array[z] == 0)
                        {
                            continue;
                        }

                        min = Math.Min(min, array[z]);
                    }

                    res += max - min;
                }
            }

            return res;
        }
    }
}
