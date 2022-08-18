using System;
namespace LeetCode
{
    public class number_of_good_ways_to_split_a_string
    {
        public int NumSplits(string s)
        {
            var res = 0;
            var leftVisit = new bool[26];
            var rightVisit = new bool[26];

            var leftDp = new int[s.Length + 2];
            var rightDp = new int[s.Length + 2];
            for (int i = 1; i < s.Length; i++)
            {
                var c = s[i - 1] - 'a';
                if (leftVisit[c])
                {
                    leftDp[i] = leftDp[i - 1];
                }
                else
                {
                    leftVisit[c] = true;
                    leftDp[i] = leftDp[i - 1] + 1;
                }
            }

            for (int i = s.Length; i > 0; i--)
            {
                var c = s[i - 1] - 'a';
                if (rightVisit[c])
                {
                    rightDp[i] = rightDp[i + 1];
                }
                else
                {
                    rightVisit[c] = true;
                    rightDp[i] = rightDp[i + 1] + 1;
                }
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (leftDp[i] == rightDp[i+1])
                {
                    res++;
                }
            }

            return res;
        }
    }
}
