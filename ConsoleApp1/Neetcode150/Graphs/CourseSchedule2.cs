public class CourseSchedule2 {
    public int[] FindOrder(int n, int[][] pre) {
        List<List<int>> adj = new();
        for(int i = 0; i < n; i++){
            adj.Add(new List<int>());
        }

        int[] degree = new int[n];
        Queue<int> queue = new();

        foreach(var edge in pre){
            int u = edge[0];
            int v = edge[1];
            adj[v].Add(u);
            degree[u]++;
        }

        List<int> result = new();

        for(int i = 0; i < n; i++){
            if(degree[i] == 0){
                queue.Enqueue(i);
            }
        }

        while(queue.Count > 0){
            var node = queue.Dequeue();
            result.Add(node);

            foreach(var neigh in adj[node]){
                degree[neigh]--;
                if(degree[neigh] == 0){
                    queue.Enqueue(neigh);
                }
            }
        }

        if(result.Count != n) return new int[]{};

        return result.ToArray();
    }
}
