using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class dota2_senate
    {
        public string PredictPartyVictory(string senate)
        {
            var radiantQueue = new Queue<int>();
            var direQueue = new Queue<int>();
            for (int i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R')
                {
                    radiantQueue.Enqueue(i);
                }
                else
                {
                    direQueue.Enqueue(i);
                }
            }

            while (radiantQueue.Any() && direQueue.Any())
            {
                var radiantIndex = radiantQueue.Dequeue();
                var direIndex = direQueue.Dequeue();
                if (radiantIndex < direIndex)
                {
                    radiantQueue.Enqueue(radiantIndex + senate.Length);
                }
                else
                {
                    direQueue.Enqueue(direIndex + senate.Length);
                }
            }

            return radiantQueue.Any()? "Radiant" : "Dire";
        }
    }
}
