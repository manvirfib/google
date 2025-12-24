public class JobSequencingSolution {
    int FindParent(int x, int[] parent){
        if(x == parent[x]) return x;
        return parent[x] = FindParent(parent[x], parent);
    }
    void Union(int u, int v, int[] parent){
        parent[u] = v;
    }
    public List<int> jobSequencing(int[] d, int[] p) {
        // code here
        int max = d.Max();
        int profit = 0, count = 0;
        int len = d.Length - 1;
        
        Array.Sort(p, d);
        
        int[] parent = new int[max + 1];
        for(int i = 0; i < max + 1; i++){
            parent[i] = i;
        }
        
        while(len >= 0){
            int j = d[len];
            int avail = FindParent(j, parent);
            if(avail > 0){
                profit += p[len];
                count++;
                Union(avail, avail - 1, parent);
            }
            len--;
        }
        
        return new List<int>() { count, profit };
    }
}