public class NumberOfProvincies
{
    public int FindCircleNum(int[][] isConnected)
    {
        int v = isConnected.Length;
        bool[] visited = new bool[v];
        int count = 0;

        for (int i = 0; i < v; i++)
        {
            if (!visited[i])
            {
                dfs(i, isConnected, visited);
                count++;
            }
        }

        return count;
    }

    void dfs(int node, int[][] isConnected, bool[] visited)
    {
        if (visited[node])
            return;
        visited[node] = true;
        for (int i = 0; i < isConnected.Length; i++)
        {
            if (node != i && isConnected[node][i] == 1)
            {
                dfs(i, isConnected, visited);
            }
        }
    }
}

public class SolutionUsingAdjacencyList {
    public int FindCircleNum(int[][] isConnected) {
        int v = isConnected.Length;
        bool[] visited = new bool[v];
        int count = 0;

        List<int>[] adj = new List<int>[v];

        for (int i = 0; i < v; i++) {
            adj[i] = new List<int>();
        }
        // Adjacency list creation instead of using adjacency matrix
        for(int i = 0; i < v; i++){
            for(int j = 0; j < v; j++){
                if(isConnected[i][j] == 1 && i != j){
                    adj[i].Add(j);
                    adj[j].Add(i);
                }
            }
        }

        for(int i = 0; i < v; i++){
            if(!visited[i]){
                dfs(i, adj, visited);
                count++;
            }
        }

        return count;
    }

    void dfs(int node, List<int>[] adj, bool[] visited){
        visited[node] = true;
        var list = adj[node];
        for(int i = 0; i < list.Count; i++){
            if(!visited[list[i]])
            dfs(list[i], adj, visited);
        }
    }
}