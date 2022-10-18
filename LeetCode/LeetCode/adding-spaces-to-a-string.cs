using System;
namespace LeetCode
{
    public class adding_spaces_to_a_string
    {
        public string AddSpaces(string s, int[] spaces)
        {
            var n = s.Length;
            var m = spaces.Length;
            var res = new char[m + n];
            var i = 0;
            var j = 0;
            while (i < n)
            {
                while (j <m && spaces[j] <= i)
                {
                    res[i + j] = ' ';
                    j++;
                }

                res[i + j] = s[i++];
            }

            return new string(res);
        }
    }
}
