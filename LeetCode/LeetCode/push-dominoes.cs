using System;
namespace LeetCode
{
	public class push_dominoes
	{
        public string PushDominoes(string dominoes)
        {
            var s = dominoes.ToCharArray();
            var n = s.Length;
            var i = 0;
            var left = 'L';
            while (i < n)
            {
                var j = i;
                while (j < n && s[j] == '.')
                {
                    j++;
                }

                char right = j < n ? s[j] : 'R';
                if (left == right)
                {
                    while (i < j)
                    {
                        s[i++] = right;
                    }
                }
                else if (left == 'R' && right == 'L')
                {
                    var k = j - 1;
                    while (i < k)
                    {
                        s[i++] = 'R';
                        s[k--] = 'L';
                    }
                }

                left = right;
                i = j + 1;
            }

            return new string(s);
        }
    }
}

