using System;
namespace LeetCode
{
	public class maximum_compatibility_score_sum
	{
        public int MaxCompatibilitySum(int[][] students, int[][] mentors)
        {
            var m = students.Length;
            var n = students[0].Length;
            var score = new int[m, m];
            var used = new bool[m];
            var res = 0;
            var cur = 0;
            for (int si = 0; si < m; si++)
            {
                for (int mi = 0; mi < m; mi++)
                {
                    var temp = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (students[si][i] == mentors[mi][i])
                        {
                            temp++;
                        }

                        score[si, mi] = temp;
                    }
                }
            }

            Backtrace(0, m, n, score, used, ref res, ref cur);
            return res;
        }

        private void Backtrace(int si, int m, int n, int[,] score, bool[] used, ref int res, ref int cur)
        {
            if (si == m)
            {
                res = Math.Max(res, cur);
                return;
            }

            for (int i = 0; i < m; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    cur += score[si, i];
                    Backtrace(si + 1, m, n, score, used, ref res, ref cur);
                    cur -= score[si, i];
                    used[i] = false;
                }
            }
        }
    }
}

