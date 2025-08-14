using System.Runtime.InteropServices;

namespace HelloWorld
{
    class BFS
    {
        public void Run(int i, int[,] A)
        {
            int len = A.GetLength(0); //7
            Queue<int> queue = new Queue<int>();
            int[] visited = new int[len];

            Console.Write(i + " ");
            queue.Enqueue(i);
            visited[i] = 1;

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();
                for (int v = 1; v < len; v++)
                {
                    if (A[u, v] == 1 && visited[v] == 0)
                    {
                        Console.Write(v + " ");
                        queue.Enqueue(v);
                        visited[v] = 1;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}