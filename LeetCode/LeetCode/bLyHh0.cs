namespace LeetCode;

public class bLyHh0
{
    public int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        var parent = new int[n];
        for (int i = 0; i < n; i++) {
            parent[i] = i;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (isConnected[i][j] == 1)
                {
                    Union(parent,i,j);
                }
            }
        }
        
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            if (parent[i] == i) {
                res++;
            }
        }
        
        return res;
    }
    
    private void Union(int[] parent, int x, int y) {
        int rootX = Find(parent, x);
        int rootY = Find(parent, y);
        if (rootX != rootY) {
            parent[rootX] = rootY;
        }
    }
    
    private int Find(int[] parent, int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent, parent[x]);
        }
        
        return parent[x];
    }
}