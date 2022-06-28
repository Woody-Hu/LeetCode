using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class reveal_cards_in_increasing_order
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            var n = deck.Length;
            var indexes = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                indexes.Enqueue(i);
            }

            Array.Sort(deck);
            var res = new int[n];
            foreach (var item in deck)
            {
                res[indexes.Dequeue()] = item;
                if (indexes.Any())
                {
                    indexes.Enqueue(indexes.Dequeue());
                }
            }

            return res;  
        }
    }
}
