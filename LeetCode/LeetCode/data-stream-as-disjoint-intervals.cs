using System.Collections.Generic;

namespace LeetCode;

public class data_stream_as_disjoint_intervals
{
    public class SummaryRanges {
        struct Range{
            public int left;
            public int right;
        }
        const int len = 10010; 
        int[] father;
        List<Range> ranges;
        public SummaryRanges() {
            ranges = new List<Range>();
            father=new int[len];
            for(int i=0;i<len;i++) father[i] = -1;
        }
    
        public void AddNum(int val) {
            if(father[val]!=-1) return;
            father[val]=val;
            Union(val,val-1);
        }
    
        int Find(int u){
            if(father[u]==-1) return u+1;
            if(father[u]!=u) father[u] = Find(father[u]);
            return father[u];
        }
        void Union(int a,int b){
            if(b<0) return;
            int fa=Find(a);
            int fb=Find(b);
            father[fa]=fb;
        }

        public int[][] GetIntervals() {
            ranges.Clear();
            int fa = -1,l = -1;
            for(int i=0;i<len;i++){
                if(father[i]!=-1){
                    if(fa==-1) {
                        fa = father[i];
                        l = i;
                    }
                }
                else{
                    if(fa!=-1){
                        ranges.Add(new Range(){ left=l,right=i-1 });
                        fa = -1;
                    }
                }
            }
            if(fa!=-1){
                ranges.Add(new Range(){ left=l,right=len-1 });
                fa = -1;
            }
            int cnt = ranges.Count;
            int[][] ans = new int[cnt][];
            for(int i=0;i<cnt;i++){
                ans[i] = new int[2]{ranges[i].left,ranges[i].right};
            }
            return ans;
        }

    }
}