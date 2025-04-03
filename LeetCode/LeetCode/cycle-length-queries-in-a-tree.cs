using System.Collections.Generic;

namespace LeetCode;

public class cycle_length_queries_in_a_tree
{
    List<int> res = new();
    Stack<int> su = new();
    Stack<int> sv = new();
    public int[] CycleLengthQueries(int n, int[][] queries) {
        for(int i = 0;i<queries.Length;i++){
            Find(queries[i]);
        }
        return res.ToArray();
    }
    public void Find(int[] query){
        int u = query[0];
        int v = query[1];
        int depthu = 0;
        int depthv = 0;
        while(u!=1){
            su.Push(u);
            if(u%2==1)
                u--;
            u/=2;
            depthu++;
        }
        while(v!=1){
            sv.Push(v);
            if(v%2==1)
                v--;
            v/=2;
            depthv++;
        }
        int deptha = 0;
        while(su.Count!=0&&sv.Count!=0&&su.Peek()==sv.Peek()){
            deptha++;
            su.Pop();
            sv.Pop();
        }
        su.Clear();
        sv.Clear();
        res.Add((depthu+depthv-2*deptha+1));
        return;
    }
}