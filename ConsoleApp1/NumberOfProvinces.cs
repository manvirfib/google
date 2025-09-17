public class NumberOfProvincies {
    public int FindCircleNum(int[][] isConnected) {
        int v = isConnected.Length;
        bool[] visited = new bool[v];
        int count = 0;

        for(int i = 0; i < v; i++){
            if(!visited[i]){
                dfs(i, isConnected, visited);
                count++;
            }
        }

        return count;
    }

    void dfs(int node, int[][] isConnected, bool[] visited){
        if(visited[node])
        return;
        visited[node] = true;
        for(int i = 0; i < isConnected.Length; i++){
            if(node != i && isConnected[node][i] == 1){
                dfs(i, isConnected, visited);
            }
        }
    }
}