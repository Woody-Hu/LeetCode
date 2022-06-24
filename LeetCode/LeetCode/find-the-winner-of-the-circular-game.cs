using System;
namespace LeetCode
{
    public class find_the_winner_of_the_circular_game
    {
        public int FindTheWinner(int n, int k)
        {
            var res = 1;
            for (int i = 2; i <= n; i++)
            {
                res = (k + res - 1) % i + 1;
            }

            return res;
        }
    }
}
