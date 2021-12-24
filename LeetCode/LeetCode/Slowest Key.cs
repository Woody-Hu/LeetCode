using System;
namespace LeetCode
{
    public class Slowest_Key
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            var max = releaseTimes[0];
            var res = keysPressed[0];
            for (int i = 1; i < keysPressed.Length; i++)
            {
                var current = releaseTimes[i] - releaseTimes[i - 1];
                if (current > max || (current == max && (keysPressed[i] > res )))
                {
                    max = current;
                    res = keysPressed[i];
                }
            }

            return res;
        }
    }
}
