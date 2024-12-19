namespace LeetCode;

public class find_champion_ii
{
    public int FindChampion(int n, int[][] edges) {
        int[] degree = new int[n];
        foreach (int[] e in edges) {
            degree[e[1]]++;
        }
        int champion = -1;
        for (int i = 0; i < n; i++) {
            if (degree[i] == 0) {
                if (champion == -1) {
                    champion = i;
                } else {
                    return -1;
                }
            }
        }
        
        return champion;
    }
}