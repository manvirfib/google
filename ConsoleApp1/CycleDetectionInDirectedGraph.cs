// User function Template for C#
class DetectCycleInDirectedUsingDfs {
    public bool IsCycle(int V, int[][] edges) {
        // Your code here
        List<int>[] adj = new List<int>[V];
        bool[] visited = new bool[V];
        bool[] path = new bool[V];
        
        for(int i = 0; i < V; i++){
            adj[i] = new List<int>();
        }
        
        for(int i = 0; i < edges.Length; i++){
            adj[edges[i][0]].Add(edges[i][1]);
        }
        
        for(int i = 0; i < V; i++){
            if(!visited[i]){
                if(dfs(i, adj, visited, path)){
                    return true;
                }
            }
        }
        
        return false;
    }
    
    bool dfs(int node, List<int>[] adj, bool[] visited, bool[] path){
        visited[node] = true;
        path[node] = true;
        
        var neighbours = adj[node];
        for(int i = 0; i < neighbours.Count; i++){
            if(!visited[neighbours[i]]){
                if(dfs(neighbours[i], adj, visited, path))
                    return true;
            }
            else if(path[neighbours[i]])
                return true;
        }
        
        path[node] = false;
        
        return false;
    }
}