public class IsBipartiteGraph {
    int v;
    Queue<int> queue;
    bool bfs(int node, int[] colors, int[][] graph){
        queue.Enqueue(node);
        colors[node] = 1;

        while(queue.Count > 0){
            int nod = queue.Dequeue();
            for(int neigh = 0; neigh < graph[nod].Length; neigh++){
                if(colors[graph[nod][neigh]] == -1){
                    colors[graph[nod][neigh]] = colors[nod]^1;
                    queue.Enqueue(graph[nod][neigh]);
                }
                else if(colors[graph[nod][neigh]] == colors[nod])
                    return false;
            }
        }

        return true;
    }
    public bool IsBipartite(int[][] graph) {
        queue = new Queue<int>();
        v = graph.Length;
        int[] colors = new int[v];
        Array.Fill(colors, -1);

        for(int i = 0; i < v; i++){
            if(colors[i] == -1){
                if(!bfs(i, colors, graph)){
                    return false;
                }
            }
        }

        return true;
    }
}