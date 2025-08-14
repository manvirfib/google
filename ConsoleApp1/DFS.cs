namespace HelloWorld
{
    class DFS
    {
        int[,] A;
        int[] visited;
        int len;
        public DFS(int[,] A)
        {
            this.A = A;
            len = A.GetLength(0);
            visited = new int[len];
        }
        public void Run(int i)
        {
            if (visited[i] == 0)
            {
                Console.Write(i + " ");
                visited[i] = 1;

                for (int v = 1; v < len; v++)
                {
                    if (visited[v] == 0 && A[i, v] == 1)
                    {
                        Run(v);
                    }
                } 
            }
        }
    }
}