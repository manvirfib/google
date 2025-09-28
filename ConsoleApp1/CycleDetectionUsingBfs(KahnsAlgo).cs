class DetectCycleUsingBfsKahnsAlgo {
    public bool IsCycle(int V, int[][] edges) {
        List<int>[] adj = new List<int>[V];
        
        for(int i = 0; i < V; i++){
            adj[i] = new List<int>();
        }
        
        for(int i = 0; i < edges.Length; i++){
            adj[edges[i][0]].Add(edges[i][1]);
        }
        
        List<int> result = new List<int>();
        int[] degree = new int[V];
        Queue<int> queue = new Queue<int>();
        for(int i = 0; i < V; i++){
            var list = adj[i];

            for(int j = 0; j < list.Count; j++){
                degree[list[j]]++;
            }
        }

        for(int i = 0; i < V; i++){
            if(degree[i] == 0){
                queue.Enqueue(i);
            }
        }

        while(queue.Count > 0){
            var value = queue.Dequeue();
            var list = adj[value];
            result.Add(value);
            for(int i = 0; i < list.Count; i++){
                degree[list[i]]--;
                if(degree[list[i]] == 0){
                    queue.Enqueue(list[i]);
                }
            }
        }

        if(result.Count == V)
        return false;
        
        return true;
    }
}