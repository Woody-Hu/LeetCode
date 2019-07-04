using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Can_I_Win
    {
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if (maxChoosableInteger >= desiredTotal)
            {
                return true;
            }

            if ((1+maxChoosableInteger)*maxChoosableInteger < 2*desiredTotal)
            {
                return false;
            }

            var dict = new Dictionary<int, bool>();
            return CanIWin(desiredTotal, 0, maxChoosableInteger, dict);
        }

        private bool CanIWin(int target, int visited, int max, Dictionary<int, bool> dict)
        {
            if (dict.ContainsKey(visited))
            {
                return dict[visited];
            }

            for (int i = 1; i <= max; i++)
            {
                var tag = 1 << i;
                if ((visited & tag) == 0 && (i >= target || !(CanIWin(target - i, visited | tag, max, dict))))
                {
                    dict[visited] = true;
                    return true;
                }
            }

            dict[visited] = false;
            return false;
        }
    }
}
