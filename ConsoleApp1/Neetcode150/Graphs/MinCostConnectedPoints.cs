public class MinCostConnectPointsSolution {
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        List<List<(int, int)>> adj = new();

        for(int i = 0; i < n; i++){
            adj.Add(new List<(int, int)>());
        }

        for(int i = 0; i < n; i++){
            int p1 = points[i][0];
            int p2 = points[i][1];
            for(int j = i + 1; j < n; j++){
                int j1 = points[j][0];
                int j2 = points[j][1];
                int dist = Math.Abs(p1 - j1) + Math.Abs(p2 - j2);
                adj[i].Add((j, dist));
                adj[j].Add((i, dist));
            }
        }

        PriorityQueue<(int, int), int> pq = new();

        int res = 0;
        bool[] visited = new bool[n];

        pq.Enqueue((0, 0), 0);

        while(pq.Count > 0){
            var (node, dist) = pq.Dequeue();
            if(visited[node]) continue;
            visited[node] = true;
            res += dist;
            foreach(var neigh in adj[node]){
                if(!visited[neigh.Item1]){
                    pq.Enqueue((neigh.Item1, neigh.Item2), neigh.Item2);
                }
            }
        }

        return res;
    }
}
