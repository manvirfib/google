public class Krushkal {
    public int spanningTree(int V, int[][] edges) {
        // code here
        int sum = 0;
        Array.Sort(edges, (a, b) => a[2].CompareTo(b[2]));
        DisjointSet ds = new DisjointSet(edges.Length);
        foreach(var edge in edges){
            if(ds.FindParent(edge[0]) != ds.FindParent(edge[1])){
                sum += edge[2];
                ds.Union(edge[0], edge[1]);
            }
        }
        return sum;
    }
}
class DisjointSet
{
    int[] rank;
    int[] parent;
    public DisjointSet(int nodes)
    {
        rank = new int[nodes + 1];
        parent = new int[nodes + 1];
        for (int i = 1; i <= nodes; i++)
        {
            parent[i] = i;
        }
    }
    public int FindParent(int x)
    {
        if (parent[x] == x)
            return x;
        parent[x] = FindParent(parent[x]);

        return parent[x];
    }
    public void Union(int u, int v)
    {
        int p_u = FindParent(u);
        int p_v = FindParent(v);
        if (rank[p_u] == rank[p_v])
        {
            rank[p_u]++;
            parent[p_v] = parent[p_u];
        }
        else if (rank[p_u] > rank[p_v])
        {
            parent[p_v] = parent[p_u];
        }
        else
        {
            parent[p_u] = parent[p_v];
        }
    }
}