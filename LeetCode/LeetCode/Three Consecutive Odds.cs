using System;
namespace LeetCode
{
    public class Three_Consecutive_Odds
    {
        public Three_Consecutive_Odds()
        {
        }

        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var count = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    count = 0;
                }
                else
                {
                    count++;
                }

                if (count == 3)
                {
                    return true;
                }
            }

            return count >= 3;
        }
    }
}
