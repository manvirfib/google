public class CountComponentsSolution {
    void dfs(int node, bool[] visited, List<List<int>> adj){
        visited[node] = true;

        foreach(var neigh in adj[node]){
            if(!visited[neigh]){
                dfs(neigh, visited, adj);
            }
        }
    }
    public int CountComponents(int n, int[][] edges) {
        List<List<int>> adj = new();

        for(int i = 0; i < n; i++){
            adj.Add(new List<int>());
        }

        foreach(var edge in edges){
            int u = edge[0];
            int v = edge[1];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        int count = 0;

        bool[] visited = new bool[n];

        for(int i = 0; i < n; i++){
            if(!visited[i]){
                count++;
                dfs(i, visited, adj);
            }
        }

        return count;
    }
}
