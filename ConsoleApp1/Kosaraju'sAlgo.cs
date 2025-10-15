public class KosarajuAlgo {
    void dfs(int node, Stack<int> stack, List<List<int>> adj, bool[] visited) {
        visited[node] = true;
        foreach (var neigh in adj[node]) {
            if (!visited[neigh]) {
                dfs(neigh, stack, adj, visited);
            }
        }
        stack.Push(node);
    }

    void dfs1(int node, List<List<int>> adj, bool[] visited) {
        visited[node] = true;
        foreach (var neigh in adj[node]) {
            if (!visited[neigh]) {
                dfs1(neigh, adj, visited);
            }
        }
    }

    public int Kosaraju(int V, List<List<int>> adj) {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[V];

        // Step 1: Fill the stack with finish times
        for (int i = 0; i < V; i++) 
            if (!visited[i]) 
                dfs(i, stack, adj, visited);

        // Step 2: Build transpose graph
        List<List<int>> adjT = new List<List<int>>();
        for (int i = 0; i < V; i++) 
            adjT.Add(new List<int>());

        for (int i = 0; i < V; i++) {
            foreach (var neigh in adj[i]) {
                adjT[neigh].Add(i);
            }
        }

        // Step 3: Run DFS in stack order
        Array.Fill(visited, false);
        int count = 0;

        while (stack.Count > 0) {
            int node = stack.Pop();
            if (!visited[node]) {
                count++;
                dfs1(node, adjT, visited);
            }
        }

        return count;
    }
}
