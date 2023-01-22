using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_number_of_groups_getting_fresh_donuts
    {
        public class Solution
        {
            const int K_WIDTH = 5;
            const int K_WIDTH_MASK = (1 << K_WIDTH) - 1;

            public int MaxHappyGroups(int batchSize, int[] groups)
            {
                int[] cnt = new int[batchSize];
                foreach (int x in groups)
                {
                    ++cnt[x % batchSize];
                }

                long start = 0;
                for (int i = batchSize - 1; i >= 1; --i)
                {
                    start = (start << K_WIDTH) | cnt[i];
                }

                IDictionary<long, int> memo = new Dictionary<long, int>();

                return DFS(memo, batchSize, start) + cnt[0];
            }

            public int DFS(IDictionary<long, int> memo, int batchSize, long mask)
            {
                if (mask == 0)
                {
                    return 0;
                }

                if (!memo.ContainsKey(mask))
                {
                    long total = 0;
                    for (int i = 1; i < batchSize; ++i)
                    {
                        long amount = ((mask >> ((i - 1) * K_WIDTH)) & K_WIDTH_MASK);
                        total += i * amount;
                    }

                    int best = 0;
                    for (int i = 1; i < batchSize; ++i)
                    {
                        long amount = ((mask >> ((i - 1) * K_WIDTH)) & K_WIDTH_MASK);
                        if (amount > 0)
                        {
                            int result = DFS(memo, batchSize, mask - (1L << ((i - 1) * K_WIDTH)));
                            if ((total - i) % batchSize == 0)
                            {
                                ++result;
                            }
                            best = Math.Max(best, result);
                        }
                    }

                    memo.Add(mask, best);
                }
                return memo[mask];
            }
        }
    }
}

