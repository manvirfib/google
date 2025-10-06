class Dikstra
{
    public int[] dijkstra(int V, int[,] edges, int src)
    {
        int[] distance = new int[V];
        Array.Fill(distance, int.MaxValue);
        distance[src] = 0;

        List<int[]>[] adj = new List<int[]>[V];
        for (int i = 0; i < V; i++) adj[i] = new List<int[]>();

        int len = edges.GetLength(0);
        for (int i = 0; i < len; i++)
        {
            adj[edges[i, 0]].Add(new int[] { edges[i, 1], edges[i, 2] });
            adj[edges[i, 1]].Add(new int[] { edges[i, 0], edges[i, 2] }); // undirected
        }

        var pq = new PriorityQueue<int, int>(); // (node, distance)
        pq.Enqueue(src, 0);

        while (pq.Count > 0)
        {
            int node = pq.Dequeue();
            foreach (var edge in adj[node])
            {
                int next = edge[0], weight = edge[1];
                if (distance[node] + weight < distance[next])
                {
                    distance[next] = distance[node] + weight;
                    pq.Enqueue(next, distance[next]);
                }
            }
        }

        return distance;
    }
}
//Single source shortest path
