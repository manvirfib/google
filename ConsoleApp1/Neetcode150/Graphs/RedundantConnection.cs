namespace Graphs
{
    public class Solution
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            int n = edges.Length;
            Disjoint ds = new Disjoint(n);
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                if (ds.FindParent(u) == ds.FindParent(v))
                    return new int[] { u, v };
                else
                {
                    ds.Union(u, v);
                }
            }

            return new int[] { };
        }
    }
    class Disjoint
    {
        int[] rank;
        int[] parent;
        public Disjoint(int cap)
        {
            rank = new int[cap + 1];
            parent = new int[cap + 1];
            for (int i = 1; i <= cap; i++)
            {
                parent[i] = i;
            }
        }
        public int FindParent(int x)
        {
            if (x == parent[x]) return x;

            return parent[x] = FindParent(parent[x]);
        }
        public void Union(int u, int v)
        {
            int p_u = FindParent(u);
            int p_v = FindParent(v);
            if (p_u == p_v) return;

            if (rank[p_u] == rank[p_v])
            {
                rank[p_u]++;
                parent[p_v] = p_u;
            }
            else if (rank[p_u] > rank[p_v])
            {
                parent[p_v] = p_u;
            }
            else
            {
                parent[p_u] = p_v;
            }
        }
    }
}
