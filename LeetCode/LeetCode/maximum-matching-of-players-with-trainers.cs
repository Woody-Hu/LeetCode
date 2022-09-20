using System;
namespace LeetCode
{
    public class maximum_matching_of_players_with_trainers
    {
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            var pn = players.Length;
            var tn = trainers.Length;
            Array.Sort(players);
            Array.Sort(trainers);
            var res = 0;
            var ti = 0;
            for (int pi = 0; pi < pn; pi++)
            {
                while (ti < tn && players[pi] > trainers[ti])
                {
                    ti++;
                }

                if (ti < tn && players[pi] <= trainers[ti])
                {
                    res++;
                    ti++;
                }
            }

            return res;
        }
    }
}
