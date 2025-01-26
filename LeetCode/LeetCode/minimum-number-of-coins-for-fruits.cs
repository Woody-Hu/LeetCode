using System.Collections.Generic;

namespace LeetCode;

public class minimum_number_of_coins_for_fruits
{
    public int MinimumCoins(int[] prices) {
        int n = prices.Length;
        var queue = new LinkedList<int[]>();
        queue.AddFirst(new int[] {n, 0});
        for (int i = n - 1; i >= 0; i--) {
            while (queue.Last.Value[0] >= 2 * i + 3) {
                queue.RemoveLast();
            }
            int cur = queue.Last.Value[1] + prices[i];
            while (queue.First.Value[1] >= cur) {
                queue.RemoveFirst();
            }
            queue.AddFirst(new int[] { i, cur });
        }
        return queue.First.Value[1];
    }
}