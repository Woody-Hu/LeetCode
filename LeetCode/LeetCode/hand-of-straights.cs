using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class hand_of_straights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            int n = hand.Length;
            if (n % groupSize != 0)
            {
                return false;
            }

            Array.Sort(hand);
            var cnt = new Dictionary<int, int>();
            foreach (int x in hand)
            {
                if (!cnt.ContainsKey(x))
                {
                    cnt.Add(x, 0);
                }
                cnt[x]++;
            }

            foreach (var item in hand)
            {
                if (!cnt.ContainsKey(item))
                {
                    continue;
                }

                for (int i = 0; i < groupSize; i++)
                {
                    var index = item + i;
                    if (!cnt.ContainsKey(index))
                    {
                        return false;
                    }

                    cnt[index]--;
                    if (cnt[index] == 0)
                    {
                        cnt.Remove(index);
                    }
                }
            }

            return true;

        }
    }
}
