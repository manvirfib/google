public class NetworkDelayTimeSolution {
    public int NetworkDelayTime(int[][] times, int n, int src) {
        PriorityQueue<int, int> pq = new();

        List<List<(int v, int wt)>> adj = new();

        for(int i = 0; i <= n; i++){
            adj.Add(new List<(int v, int wt)>());
        }

        foreach(var edge in times){
            int u = edge[0];
            int v = edge[1];
            int time = edge[2];
            adj[u].Add((v, time));
        }

        int[] dist = new int[n + 1];
        Array.Fill(dist, int.MaxValue);
        dist[src] = 0;
        pq.Enqueue(src, 0);

        while(pq.Count > 0){
            var node = pq.Dequeue();
            foreach(var neigh in adj[node]){
                if((dist[node] + neigh.wt) < dist[neigh.v]){
                    dist[neigh.v] = dist[node] + neigh.wt;
                    pq.Enqueue(neigh.v, dist[neigh.v]);
                }
            }
        }

        int max = 0;

        for(int i = 1; i <= n; i++){
            max = Math.Max(dist[i], max);
        }

        return max == int.MaxValue ? -1 : max;
    }
}
