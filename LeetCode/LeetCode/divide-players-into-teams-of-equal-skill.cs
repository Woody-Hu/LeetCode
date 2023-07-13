using System;
using System.Linq;

namespace LeetCode
{
	public class divide_players_into_teams_of_equal_skill
	{
        public long DividePlayers(int[] skill)
        {
            Array.Sort(skill);
            var s = skill.First() + skill.Last();
            long res = 0;
            for (int i = 0; i < skill.Length / 2; i++)
            {
                var x = skill[i];
                var y = skill[skill.Length - 1 - i];
                if (x + y != s)
                {
                    return -1;
                }

                res += x * y;
            }

            return res;
        }
    }
}

