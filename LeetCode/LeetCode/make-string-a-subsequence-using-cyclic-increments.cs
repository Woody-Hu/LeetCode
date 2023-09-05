using System;
namespace LeetCode
{
	public class make_string_a_subsequence_using_cyclic_increments
	{
        public bool CanMakeSubsequence(string str1, string str2)
        {
            var i = 0;
            var j = 0;
            while (i < str1.Length && j < str2.Length)
            {
                if (str2.Length - j > str1.Length - i)
                {
                    return false;
                }

                var c = str1[i];
                var c1 = (char)(c + 1);
                if (c1 > 'z')
                {
                    c1 = 'a';
                }

                if (c != str2[j] && c1 != str2[j])
                {
                    i++;
                    continue;
                }

                if (j == str2.Length - 1)
                {
                    return true;
                }

                i++;
                j++;
            }

            return false;
        }
    }
}

