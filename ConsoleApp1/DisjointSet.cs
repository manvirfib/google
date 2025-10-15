class Disjoint
{
    int nodes;
    int[] rank;
    int[] parent;
    public Disjoint(int nodes)
    {
        this.nodes = nodes;
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