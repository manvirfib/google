public class TarjanAlgo
{
    int timer = 0;
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
    {
        bool[] visited = new bool[n];
        List<List<int>> adj = new List<List<int>>();
        int[] low = new int[n];
        int[] lev = new int[n];

        for (int i = 0; i < n; i++)
        {
            adj.Add(new List<int>());
        }

        foreach (var conn in connections)
        {
            int u = conn[0];
            int v = conn[1];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                timer++;
                dfs(i, -1, lev, low, visited, adj, result);
            }
        }

        return result;
    }
    void dfs(int node, int parent, int[] lev, int[] low, bool[] visited, List<List<int>> adj, List<IList<int>> result)
    {
        visited[node] = true;
        lev[node] = low[node] = timer++;

        foreach (var neigh in adj[node])
        {
            if (neigh == parent) continue;
            if (!visited[neigh])
            {
                dfs(neigh, node, lev, low, visited, adj, result);
                low[node] = Math.Min(low[node], low[neigh]);
                if (lev[node] < low[neigh])
                {
                    result.Add(new List<int>() { node, neigh });
                }
            }
            else
            {
                low[node] = Math.Min(low[node], low[neigh]);
            }
        }
    }
}

// This algorithm is beneficial in order to find bridges.