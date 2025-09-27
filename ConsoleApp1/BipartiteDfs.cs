public class IsBipartiteDfs {
    int v;
    public bool IsBipartite(int[][] graph) {
        v = graph.Length;
        int[] colors = new int[v];
        Array.Fill(colors, -1);

        for(int i = 0; i < v; i++){
            if(colors[i] == -1){
                colors[i] = 0;
                if(!dfs(i, colors, graph)){
                    return false;
                }
            }
        }

        return true;
    }

    bool dfs(int node, int[] colors, int[][] graph){
        int size = graph[node].Length;
        for(int i = 0; i < size; i++){
            if(colors[graph[node][i]] == -1){
                colors[graph[node][i]] = colors[node]^1;
                if(!dfs(graph[node][i], colors, graph)){
                    return false;
                }
            }
            else if(colors[graph[node][i]] == colors[node]){
                return false;
            }
        }

        return true;
    }
}