namespace Graphs
{
    class Graph
    {
        public void Input(int n, int m)
        {
            // Assuming 1-based index
            bool[,] graph = new bool[n + 1, n + 1];
            int u, v;
            List<(int node, int wt)>[] adjacencyList = new List<(int node, int wt)>[n + 1];

            for (int i = 0; i <= n; i++)   // <= because we are using 1-based indexing
            {
                adjacencyList[i] = new List<(int node, int wt)>();
            }

            for (int i = 0; i < m; i++)
            {
                string[] parts = Console.ReadLine().Split();
                u = int.Parse(parts[0]);
                v = int.Parse(parts[1]);
                adjacencyList[u].Add((v, 2));
                adjacencyList[v].Add((u, 2));
            }

            // for (int i = 0; i < m; i++)
            // {
            //     string[] parts = Console.ReadLine().Split();
            //     u = int.Parse(parts[0]);
            //     v = int.Parse(parts[1]);

            //     graph[u, v] = true;
            //     graph[v, u] = true;
            // }

            // Displaying Adjacency Matrix(undirected graph)
            // for (int i = 1; i <= n; i++)
            // {
            //     for (int j = 1; j <= n; j++)
            //     {
            //         Console.Write(graph[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}