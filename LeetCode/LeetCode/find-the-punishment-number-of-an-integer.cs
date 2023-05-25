using System;
namespace LeetCode
{
	public class find_the_punishment_number_of_an_integer
	{
        public class Solution
        {
            private readonly int[] _preCalculated = new int[1001];

            public Solution()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    var s = (i * i).ToString().ToCharArray();
                    _preCalculated[i] = _preCalculated[i - 1] + (DFS(s, i, 0, 0) ? i * i : 0);
                }
            }

            private bool DFS(char[] s, int i, int p, int sum)
            {
                if (p == s.Length)
                {
                    return sum == i;
                }

                var temp = 0;
                for (int j = p; j < s.Length; j++)
                {
                    temp = temp * 10 + s[j] - '0';
                    if (DFS(s, i, j + 1, sum +temp))
                    {
                        return true;
                    }
                }

                return false;
            }

            public int PunishmentNumber(int n)
            {
                return _preCalculated[n];
            }
        }
    }
}

