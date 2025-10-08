using System;
using System.Collections.Generic;

public class PrimsAlgorithm
{
    public int SpanningTree(int V, int[][] edges)
    {
        // Adjacency list
        List<(int, int)>[] adj = new List<(int, int)>[V];
        for (int i = 0; i < V; i++)
            adj[i] = new List<(int, int)>();

        // Build the graph
        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int wt = edge[2];
            adj[u].Add((v, wt));
            adj[v].Add((u, wt));
        }

        // Prim's algorithm
        bool[] visited = new bool[V];
        int sum = 0;
        var pq = new PriorityQueue<(int node, int wt), int>();

        // Start with node 0
        pq.Enqueue((0, 0), 0);

        while (pq.Count > 0)
        {
            var (node, wt) = pq.Dequeue();

            // Skip if already included in MST
            if (visited[node])
                continue;

            visited[node] = true;
            sum += wt;

            foreach (var (n, w) in adj[node])
            {
                if (!visited[n])
                    pq.Enqueue((n, w), w);
            }
        }

        return sum;
    }
}

//Algo to find MST
