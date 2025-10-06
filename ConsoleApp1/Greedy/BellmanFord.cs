public class BellmanFordAlgorithm
{
    public int[] BellmanFord(int V, List<List<int>> edges, int S)
    {
        int[] distance = new int[V];
        Array.Fill(distance, int.MaxValue);

        distance[S] = 0;

        // Relax all edges V-1 times
        for (int i = 0; i < V - 1; i++)
        {
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                int wt = edge[2];

                if (distance[u] != int.MaxValue && distance[u] + wt < distance[v])
                {
                    distance[v] = distance[u] + wt;
                }
            }
        }

        // Check for negative weight cycle
        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int wt = edge[2];

            if (distance[u] != int.MaxValue && distance[u] + wt < distance[v])
            {
                // Negative cycle detected
                return new int[] { -1 };
            }
        }

        return distance;
    }
}
