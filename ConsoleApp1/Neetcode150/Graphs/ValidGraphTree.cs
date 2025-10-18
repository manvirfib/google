public class ValidTreeGraph {
    bool dfs(int node, bool[] visited, int parent, List<List<int>> adj){
        visited[node] = true;

        foreach(var neigh in adj[node]){
            if(neigh == parent) continue;
            if(!visited[neigh]){
                if(!dfs(neigh, visited, node, adj)){
                    return false;
                }
            }
            else{
                return false;
            }
        }

        return true;
    }
    public bool ValidTree(int n, int[][] edges) {
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

        bool[] visited = new bool[n];

        bool flag = true;
        flag = dfs(0, visited, -1, adj);

        for(int i = 0; i < n; i++){
            if(!visited[i])
            flag = false;
        }

        return flag;
    }
}
