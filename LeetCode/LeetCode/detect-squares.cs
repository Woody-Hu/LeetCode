using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class detect_squares
	{
        public class DetectSquares
        {
            private readonly Dictionary<int, Dictionary<int, int>> _cnt;

            public DetectSquares()
            {
                _cnt = new Dictionary<int, Dictionary<int, int>>();
            }

            public void Add(int[] point)
            {
                int x = point[0], y = point[1];
                if (!_cnt.ContainsKey(y))
                {
                    _cnt.Add(y, new Dictionary<int, int>());
                }

                var yCnt = _cnt[y];
                if (!yCnt.ContainsKey(x))
                {
                    yCnt.Add(x, 0);
                }
                yCnt[x]++;
            }

            public int Count(int[] point)
            {
                int res = 0;
                int x = point[0], y = point[1];
                if (!_cnt.ContainsKey(y))
                {
                    return 0;
                }

                var yCnt = _cnt[y];
                foreach (var pair in _cnt)
                {
                    int col = pair.Key;
                    var colCnt = pair.Value;
                    if (col != y)
                    {
                        var d = col - y;
                        res += (colCnt.ContainsKey(x) ? colCnt[x] : 0) * (yCnt.ContainsKey(x + d) ? yCnt[x + d] : 0) * (colCnt.ContainsKey(x + d) ? colCnt[x + d] : 0);
                        res += (colCnt.ContainsKey(x) ? colCnt[x] : 0) * (yCnt.ContainsKey(x - d) ? yCnt[x - d] : 0) * (colCnt.ContainsKey(x - d) ? colCnt[x - d] : 0);
                    }
                }

                return res;
            }
        }
    }
}

