namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[,] {
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 1, 0, 0 },
                { 0, 1, 0, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 1, 1 },
                { 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0 }
            };

            BFS bfs = new BFS();
            bfs.Run(5, graph);

            DFS dfs = new DFS(graph);
            dfs.Run(4);
        }
    }
}