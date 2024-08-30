using System;
using System.Collections.Generic;

namespace LeetCode;

public class contain_virus
{
 static int[][] dirs = {new int[]{-1, 0}, new int[]{1, 0}, new int[]{0, -1}, new int[]{0, 1}};

    public int ContainVirus(int[][] isInfected) {
        int m = isInfected.Length, n = isInfected[0].Length;
        int ans = 0;
        while (true) {
            IList<ISet<int>> neighbors = new List<ISet<int>>();
            IList<int> firewalls = new List<int>();
            for (int i = 0; i < m; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (isInfected[i][j] == 1) {
                        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
                        queue.Enqueue(new Tuple<int, int>(i, j));
                        ISet<int> neighbor = new HashSet<int>();
                        int firewall = 0, idx = neighbors.Count + 1;
                        isInfected[i][j] = -idx;

                        while (queue.Count > 0) {
                            Tuple<int, int> tuple = queue.Dequeue();
                            int x = tuple.Item1, y = tuple.Item2;
                            for (int d = 0; d < 4; ++d) {
                                int nx = x + dirs[d][0], ny = y + dirs[d][1];
                                if (nx >= 0 && nx < m && ny >= 0 && ny < n) {
                                    if (isInfected[nx][ny] == 1) {
                                        queue.Enqueue(new Tuple<int, int>(nx, ny));
                                        isInfected[nx][ny] = -idx;
                                    } else if (isInfected[nx][ny] == 0) {
                                        ++firewall;
                                        neighbor.Add(GetHash(nx, ny));
                                    }
                                }
                            }
                        }
                        neighbors.Add(neighbor);
                        firewalls.Add(firewall);
                    }
                }
            }

            if (neighbors.Count == 0) {
                break;
            }

            int maxIdx = 0;
            for (int i = 1; i < neighbors.Count; ++i) {
                if (neighbors[i].Count > neighbors[maxIdx].Count) {
                    maxIdx = i;
                }
            }
            ans += firewalls[maxIdx];
            for (int i = 0; i < m; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (isInfected[i][j] < 0) {
                        if (isInfected[i][j] != -maxIdx - 1) {
                            isInfected[i][j] = 1;
                        } else {
                            isInfected[i][j] = 2;
                        }
                    }
                }
            }
            for (int i = 0; i < neighbors.Count; ++i) {
                if (i != maxIdx) {
                    foreach (int val in neighbors[i]) {
                        int x = val >> 16, y = val & ((1 << 16) - 1);
                        isInfected[x][y] = 1;
                    }
                }
            }
            if (neighbors.Count == 1) {
                break;
            }
        }
        return ans;
    }

    public int GetHash(int x, int y) {
        return (x << 16) ^ y;
    }
}