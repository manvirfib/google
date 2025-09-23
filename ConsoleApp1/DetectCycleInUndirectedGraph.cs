class DetectCycleUsingBfs {
    int rows;
    public bool IsCycle(int V, int[,] edges) {
        // Code here
        List<int>[] adj = new List<int>[V];
        bool[] visited = new bool[V];
        for(int i = 0; i < V; i++){
            adj[i] = new List<int>();
        }
        
        rows = edges.GetLength(0);
        
        for(int i = 0; i < rows; i++){
            adj[edges[i,0]].Add(edges[i,1]);
            adj[edges[i,1]].Add(edges[i,0]);
        }
        
        Queue<int[]> queue = new Queue<int[]>();
        
        queue.Enqueue(new int[]{ 0, -1 });
        visited[0] = true;
        
        while(queue.Count > 0){
            var node = queue.Dequeue();
            var list = adj[node[0]];
            for(int i = 0; i < list.Count; i++){
                if(!visited[list[i]]){
                    queue.Enqueue(new int[] { list[i], node[0]});
                    visited[list[i]] = true;
                }
                else if(list[i] != node[1]){
                    return true;
                }
            }
        }
        
        return false;
    }
}