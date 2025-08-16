namespace HelloWorld
{
    class DisjointSubset
    {
        int[] parent;
        public DisjointSubset(int nodes)
        {
            parent = new int[nodes + 1];

            Array.Fill(parent, -1);
        }
        public void Union(int u, int v)
        {
            if (parent[u] > parent[v])
            {
                parent[v] = parent[v] + parent[u];
                parent[u] = v;
            }
            else
            {
                parent[u] = parent[v] + parent[u];
                parent[v] = u;
            }
        }

        public int FindParent(int x)
        {
            while (parent[x] > 0)
            {
                x = parent[x];
            }

            return x;
        }
    }

    class Kruskal
    {
        int[,] edges;
        int nodes;
        bool[] selected;
        DisjointSubset ds;
        public Kruskal(int[,] edges, int nodes)
        {
            this.edges = edges;
            this.nodes = nodes;
            selected = new bool[edges.GetLength(0)];
            ds = new DisjointSubset(nodes);
        }

        public int FindMST()
        {
            int cost = 0;

            int edgesCount = 0;

            while (edgesCount < nodes - 1)
            {
                int i = GetMinimumCostIndex();
                int u = edges[i, 0], v = edges[i, 1];

                if (ds.FindParent(u) != ds.FindParent(v))
                {
                    cost += edges[i, 2];
                    edgesCount++;
                    ds.Union(u, v);
                }

                selected[i] = true;
            }

            return cost;
        }

        public int GetMinimumCostIndex()
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] == false && min > edges[i, 2])
                {
                    min = edges[i, 2];
                    index = i;
                }
            }
            return index;
        }
    }
}