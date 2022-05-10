using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class design_a_leaderboard
    {
        public class Leaderboard
        {
            private Dictionary<int, int> _values = new Dictionary<int, int>();

            public Leaderboard()
            {

            }

            public void AddScore(int playerId, int score)
            {
                var exist = 0;
                if (_values.ContainsKey(playerId))
                {
                    exist = _values[playerId];
                }

                _values[playerId] = exist + score;
            }

            public int Top(int K)
            {
                var values = _values.Values.OrderByDescending(k => k);
                var res = 0;
                for (int i = 0; i < K; i++)
                {
                    res += values.ElementAt(i);
                }

                return res;
            }

            public void Reset(int playerId)
            {
                _values.Remove(playerId);
            }
        }
    }
}
